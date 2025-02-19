﻿using eBook.DataAccess.Repository.IRepository;
using eBook.Model.Models;
using eBooksWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace eBook.DataAccess.Repository
{
    public class ProductRepository :Repository<Product>, IProductRepository
    {
        private ApplicationContextDB _db;
        public ProductRepository(ApplicationContextDB db) : base(db)
        {
            _db = db;
        }
        public void Update(Product obj)
        {
            _db.Products.Update(obj);
        }
    }
}
