using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAIRCMS.Application.Interfaces
{
    public interface IDapperService:IDisposable
    {
        Task<IList<T>> QueryAsync<T>(string query);
        Task<T> QueryAsync<T>(string query, int obj);
        Task<int> InsertAsync<T>(string query,T model);
        Task<int> UpdateAsync<T>(string query,T model);
        Task<int> DeleteAsync<T>(string query,int obj);
        void StartTransaction();
        void CommitTransaction();
        void RollbackTransaction();
        Task<IList<T>> QueryTransactionAsync<T>(string query, int obj);
        Task<int> InsertTransactionAsync<T>(string query, T obj);


    }
}
