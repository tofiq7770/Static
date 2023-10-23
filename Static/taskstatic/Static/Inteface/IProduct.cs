using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Inteface
{
    public interface IProduct
    {
        int GetCount();
        Product[] Search(string searchText);
        Product[] GetAll();
        Decimal GetAvaragePrice();
        Product[] OrderByDate();
        Product[] CategoryName(string categoryname);

        Product[] GetAllByCategoryId(int id);


    }
}
