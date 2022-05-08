//using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAIRCMS.Infrastructure.DataAccess
{
    public class SqlConnectionConfiguration
    {
        private readonly IConfiguration _configuration;
        
        public SqlConnectionConfiguration(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public IDbConnection Connection => new SqlConnection(_configuration.GetConnectionString("DBString"));
        public IDbTransaction Transaction;
    }
}
