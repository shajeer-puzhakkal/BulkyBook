using BulkyBook.DAL.Repository.IRepository;
using BulkyBook.Data;
using BulkyBook.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BulkyBook.DAL.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;

        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Category category)
        {
            var obj = _db.Categories.FirstOrDefault(i => i.Id == category.Id);

            if (category.Name != null)
            {
                obj.Name = category.Name;
                _db.SaveChanges();
            }
        }
    }
}
