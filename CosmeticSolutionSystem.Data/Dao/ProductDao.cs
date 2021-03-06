﻿using CosmeticSolutionSystem.Data.Models;
using EFLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticSolutionSystem.Data
{
    public class ProductDao : SingleKeyDao<Product, int>
    {
        internal ProductDao() { }
        protected override Expression<Func<Product, int>> KeySelector
        {
            get
            {
                return x => x.BrandId;
            }
        }
    }
}
