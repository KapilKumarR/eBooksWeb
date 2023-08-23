using eBook.DataAccess.Repository.IRepository;
using eBooksWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace eBook.DataAccess.Repository
{
    public class CategoryRepository :Repository<Category>, ICategoryRepository
    {
        private ApplicationContextDB _db;
        public CategoryRepository(ApplicationContextDB db) : base(db)
        {
            _db = db;
        }
        public void Update(Category category)
        {
            _db.categories.Update(category);
        }
    }
}
