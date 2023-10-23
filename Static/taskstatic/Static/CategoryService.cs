using Domain.Data;
using Domain.Models;
using Service.Inteface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static.Controllers
{
    public class CategoryService : ICategory
    {
        private readonly AppDbContext _context;
        public CategoryService()
        {
            _context = new AppDbContext();
        }

        Category[] ICategory.GetAll()
        {
            return _context.Categories();
        }
    }
}
