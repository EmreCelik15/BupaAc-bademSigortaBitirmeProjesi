﻿using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DataAccess.Abstract.IEntityRepository;

namespace DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
    }
}
