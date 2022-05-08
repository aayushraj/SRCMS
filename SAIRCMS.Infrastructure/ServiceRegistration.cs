using SAIRCMS.Application.Interfaces;
using SAIRCMS.Infrastructure.DataAccess;
using SAIRCMS.Infrastructure.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAIRCMS.Infrastructure
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructure(this IServiceCollection services)
        {
            services.AddScoped(typeof(SqlConnectionConfiguration));
            services.AddScoped(typeof(IDapperService), typeof(DapperService));
        }
    }
}
