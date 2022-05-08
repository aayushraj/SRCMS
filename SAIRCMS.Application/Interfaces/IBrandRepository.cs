﻿using SAIRCMS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAIRCMS.Application.Interfaces
{
    public interface IBrandRepository:IGenericRepository<Brand>
    {
        string GetString();
    }
}
