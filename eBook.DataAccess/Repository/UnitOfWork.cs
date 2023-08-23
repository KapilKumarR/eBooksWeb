using eBook.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBook.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationContextDB _db;
        public ICategoryRepository Category { get; private set; }
        public IProductRepository Product { get; private set; }
        public UnitOfWork(ApplicationContextDB db)
        { 
            _db = db;
            Category = new CategoryRepository(_db);
            Product = new ProductRepository(_db);
        }     
        void IUnitOfWork.Save()
        {
            _db.SaveChanges();
        }
    }
}
