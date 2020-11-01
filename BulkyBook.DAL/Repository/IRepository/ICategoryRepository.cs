using BulkyBook.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BulkyBook.DAL.Repository.IRepository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        void Update(Category category);
    }
}
