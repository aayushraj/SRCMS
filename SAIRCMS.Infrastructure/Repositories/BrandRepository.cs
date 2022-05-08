using SAIRCMS.Application.Interfaces;
using SAIRCMS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAIRCMS.Infrastructure.Repositories
{
    public class BrandRepository : IBrandRepository
    {
        public Task<int> AddAsync(Brand entity)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<Brand>> GetAllAsync()
        {
           
            
            throw new NotImplementedException();
        }

        public Task<Brand> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public string GetString()
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAsync(Brand entity)
        {
            throw new NotImplementedException();
        }

       
    }
}
