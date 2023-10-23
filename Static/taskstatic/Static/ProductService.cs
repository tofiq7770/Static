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
    public class ProductService : IProduct
    {
        private readonly AppDbContext _context;
        public ProductService()
        {
            _context = new AppDbContext();
        }

        public Product[] GetAllByCategoryId(int id)
        {
            return _context.Products().Where(x => x.Id == id).ToArray();
        }

        public decimal GetAvaragePrice()
        {
            throw new NotImplementedException();
        }

        public object Search(string? searchText)
        {
            throw new NotImplementedException();
        }

        public Product[] OrderByDate()
        {
            throw new NotImplementedException();
        }

        public object GetAll()
        {
            throw new NotImplementedException();
        }

        Product[] IProduct.CategoryName(string categoryname)
        {
            return _context.Products().Where(m => m.Category.Name == categoryname).ToArray();
        }



        Product[] IProduct.Search(string searchText)
        {
            return _context.Products().Where(x => x.Name.Trim().ToLower().Contains(searchText.Trim().ToLower())).ToArray();
        }

        public int GetCount()
        {
            throw new NotImplementedException();
        }

        Product[] IProduct.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
