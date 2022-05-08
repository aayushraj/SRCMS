using Dapper;
using SAIRCMS.Application.Interfaces;
using SAIRCMS.Application.Utility;
using SAIRCMS.Domain;
using SAIRCMS.Infrastructure.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SAIRCMS.Infrastructure.Repositories
{
    public class DapperService : IDapperService
    {
        public enum Operation
        {
            Select,
            Insert,
            Update,
            Delete

        }
        private readonly SqlConnectionConfiguration _configuration;
        
        public DapperService(SqlConnectionConfiguration configuration)
        {
            _configuration = configuration;
        }
        private IDbTransaction _transaction;
        private IDbConnection _connection;
        public async Task<int> DeleteAsync<T>(string query, int obj)
        {
            using (var con = _configuration.Connection)
            {
                con.Open();
                var result = await con.ExecuteAsync(query, SetParameters<T>(obj, Operation.Update));
                return result;
            }
        }

        public async Task<int> InsertAsync<T>(string query, T obj)
        {
            using (var con = _configuration.Connection)
            {
                var param = SetParameters<T>(obj, Operation.Insert);
                con.Open();
                var result = await con.ExecuteAsync(query, param);
                return param.Get<int>("ReturnedId");
            }

        }

        public async Task<IList<T>> QueryAsync<T>(string query)
        {
            using (var con = _configuration.Connection)
            {
                con.Open();
                IEnumerable<T> result = await con.QueryAsync<T>(query);
                return result.ToList();
            }
        }

        public async Task<T> QueryAsync<T>(string query, int obj)
        {
            using (var con = _configuration.Connection)
            {
                con.Open();
                var result = await con.QueryAsync<T>(query, SetParameters<T>(obj, 0));
                return result.FirstOrDefault();
            }
        }

        public async Task<int> UpdateAsync<T>(string query, T obj)
        {
            using (var con = _configuration.Connection)
            {
                var param = SetParameters<T>(obj, Operation.Insert);
                con.Open();
                var result = await con.ExecuteAsync(query, SetParameters<T>(obj, Operation.Update));
                return param.Get<int>("Id");
            }
        }

        public void StartTransaction()
        {
            _connection = _configuration.Connection;
            _connection.Open();
            _transaction = _connection.BeginTransaction();
        }

        public void CommitTransaction()
        {
            _transaction?.Commit();
            _connection?.Close();
        }

        public void RollbackTransaction()
        {
            _transaction?.Rollback();
            _connection?.Close();
        }

        public async Task<int> InsertTransactionAsync<T>(string query, T obj)
        {
            var param = SetParameters<T>(obj, Operation.Insert);
            var result = await _connection.ExecuteAsync(query, param, transaction: _transaction);
            return param.Get<int>("ReturnedId");
        }
        public async Task<IList<T>> QueryTransactionAsync<T>(string query, int obj)
        {
            var result = await _connection.QueryAsync<T>(query, SetParameters<T>(obj, 0), transaction: _transaction);
            return result.ToList();
        }
        private static DynamicParameters SetParameters<T>(object obj, Operation operation)
        {
            DynamicParameters param = new();
            Type[] types = obj.GetType().GetNestedTypes(BindingFlags.Public);
            //To Get SCOPEINDENTITY
            if (operation.Equals(Operation.Insert) || operation.Equals(Operation.Update))
            {
                param.Add("@ReturnedId", 0, DbType.Int32, ParameterDirection.Output);
            }

            //For concatenating EntityName with "Id". Ex - "Brand" + "Id" as "BrandId"
            if (obj.GetType().IsValueType)
            {
                string prefixName = string.Empty;
                string suffixName = "Id";

                param.Add($"{ prefixName}{suffixName}", obj);
            }
            //if (operation.Equals(Operation.Update) || operation.Equals(Operation.Delete))
            //{
            //    param.Add("Id", obj);
            //    return param;
            //}
            foreach (var property in obj.GetType().GetProperties())
            {
                var suppress = new Suppress();

                //Suppresses Class Properties
                if (suppress.SuppressProperty(property)) 
                    continue;
                
                //Suppresses Class
                var propertyName = suppress.SuppressClass(property);
                if (propertyName !=null)
                {
                    var value = GetPropertyValue(obj, $"{property.Name}.Id");
                    param.Add(propertyName, value);
                    continue;
                }

                param.Add(property.Name, property.GetValue(obj));
            }
            return param;
        }

        private static object GetPropertyValue(object obj, string propertyName)
        {
            var _propertyNames = propertyName.Split('.');

            for (var i = 0; i < _propertyNames.Length; i++)
            {
                if (obj != null)
                {
                    var _propertyInfo = obj.GetType().GetProperty(_propertyNames[i]);
                    if (_propertyInfo != null)
                        obj = _propertyInfo.GetValue(obj);
                    else
                        obj = null;
                }
            }

            return obj;
        }
        public void Dispose()
        {
            _connection?.Close();
            _configuration.Connection?.Close();
        }
    }

}
