//using Dapper.Contrib.Extensions;
using Dapper.Contrib.Extensions;
using SAIRCMS.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using KeyAttribute = System.ComponentModel.DataAnnotations.KeyAttribute;

namespace SAIRCMS.Application.Utility
{
    
    public class QueryBuilder
    {
        public enum Operation
        {
            Select,
            Insert,
            Update,
            Delete
        }
        //OPeration
        //TableName
        // set 
        //ColumnNames = values
        //where clause
        private StringBuilder query = new StringBuilder();
        public string Query<T>(Operation operation,object obj,bool IsPredicate)
        {
            IsPredicate = false;
            switch (operation)
            {
                case Operation.Insert:
                    GetInsertQuery<T>(obj);
                    break;
                case Operation.Update:
                    GetUpdateQuery();
                    break;
                case Operation.Select:
                    if (obj != null) GetSelectQuery<T>(obj);
                    else GetSelectQuery<T>();
                    break;
                default:
                    break;
            }
           
            //AddParams<T>();
            //if (IsPredicate)
            //{
            //    GetPredicate<T>();
            //}

            return query.ToString();
        }

        private void GetUpdateQuery()
        {
            query.Append(" SET ");
        }
        private void GetInsertQuery<T>(object obj)
        {
            string comma = string.Empty;
            string tableName = GetTableName<T>();
            query.Append($"INSERT INTO {tableName}");

            query.Append("(");
            foreach (var property in obj.GetType().GetProperties())
            {
                var suppress = new Suppress();
                var propertyName = suppress.SuppressClass(property);
                if (suppress.SuppressProperty(property)) continue;
                
                //var attribute = Attribute.GetCustomAttribute(property, typeof(KeyAttribute));
                //var ignoreCase = Attribute.GetCustomAttribute(property, typeof(IgnoreCase));
                //var cascadingType = Attribute.GetCustomAttribute(property, typeof(CascadingType));

                //if (attribute != null || ignoreCase != null) continue;

                query.Append(comma);
                comma = ",";
                if (propertyName != null)
                {
                    query.Append(propertyName);
                    continue;
                }
                query.Append(property.Name);
            }

            comma = string.Empty;

            query.Append(")");
            query.Append("VALUES");
            query.Append("(");

            foreach (var property in obj.GetType().GetProperties())
            {
                var attribute = Attribute.GetCustomAttribute(property, typeof(KeyAttribute));
                var ignoreCase = Attribute.GetCustomAttribute(property, typeof(IgnoreCase));
                var cascadingType = Attribute.GetCustomAttribute(property, typeof(CascadingType));

                if (attribute != null || ignoreCase!=null) continue;
                query.Append(comma);
                comma = ",";
                query.Append("@");
                if (cascadingType != null)
                {
                    var propertyName = $"{property.Name}Id";
                    query.Append(propertyName);
                    continue;
                }
                query.Append(property.Name);
            }

            query.Append(")");
            query.Append("SELECT @ReturnedId = SCOPE_IDENTITY()");
        }

        private void GetSelectQuery<T>()
        {
            var type = typeof(T).GetType();
            var name = type.Name;
            var tablename = GetTableName<T>();
            query.Append("SELECT * from ");
            query.Append(GetTableName<T>());
        }
        private void GetSelectQuery<T>(object obj)
        {
            GetSelectQuery<T>();
            query.Append(" WHERE Id=@Id");
        }

        private void GetPredicate<T>()
        {
            query.Append("WHERE");
        }

        private void AddParams<T>()
        {
            string prefix = "";
            foreach (var item in typeof(T).GetType().GetProperties())
            {
                query.Append(prefix);
                prefix = ",";

                

                query.Append($"{item.Name} = @{item.GetValue(item.Name)}");


            }
        }

        private string GetTableName<T>()
        {
            // Check if we've already set our custom table mapper to TableNameMapper.
            if (SqlMapperExtensions.TableNameMapper != null)
                return SqlMapperExtensions.TableNameMapper(typeof(T));

            // If not, we can use Dapper default method "SqlMapperExtensions.GetTableName(Type type)" which is unfortunately private, that's why we have to call it via reflection.
            string getTableName = "GetTableName";
            MethodInfo getTableNameMethod = typeof(SqlMapperExtensions).GetMethod(getTableName, BindingFlags.NonPublic | BindingFlags.Static);

            if (getTableNameMethod == null)
                throw new ArgumentOutOfRangeException($"Method '{getTableName}' is not found in '{nameof(SqlMapperExtensions)}' class.");

            return getTableNameMethod.Invoke(null, new object[] { typeof(T) }) as string;

        }
    }
}
