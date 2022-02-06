using DAL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class ProductService
    {
        private static ProductService _instance;
        public static ProductService Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new ProductService();
                }
                return _instance;
            }
        }
        private ProductService() { }

        public List<Product> GetAllProductsCount()
        {
            using (var context = new StoreContext()) 
            {
                return context.Products
                    .OrderBy(p => p.Stock)
                    .ToList();
            }
        }

        public string GetStatus(int stock)
        {
            if (stock > 3)
            {
                return "OK";
            }
            else if (stock > 0 && stock < 4)
            {
                return "Almost Gone";
            }
            return "Gone";
        }

        public void UpdateStock(int id, int newcount)
        {
            using (var context = new StoreContext())
            {
                var product = context.Products
                    .Where(p => p.ProductID == id)
                    .First();
                product.Stock = newcount;
                context.SaveChanges();
            }
            
        }

        public List<Product> GetProductFromParameter(string department, int count)
        {
            using (var context = new StoreContext())
            {
                return context.productsInDepartments
                    .Where(pd => pd.Department.Name == department)
                    .Select(p => p.Product)
                    .Where(p=> p.Stock <= count)
                    .ToList();
            }
        }

    }
}
