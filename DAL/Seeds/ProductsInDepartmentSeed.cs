using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Seeds
{
    public static class ProductsInDepartmentSeed
    {
        public static void ProductsInDepartmentSeeder(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductsInDepartment>().HasData(
                new ProductsInDepartment { ProductID = 1, DepartmentID = 1 },
                new ProductsInDepartment { ProductID = 2, DepartmentID = 1 },
                new ProductsInDepartment { ProductID = 3, DepartmentID = 1 },
                new ProductsInDepartment { ProductID = 4, DepartmentID = 2 },
                new ProductsInDepartment { ProductID = 5, DepartmentID = 2 },
                new ProductsInDepartment { ProductID = 6, DepartmentID = 2 },
                new ProductsInDepartment { ProductID = 7, DepartmentID = 3 },
                new ProductsInDepartment { ProductID = 8, DepartmentID = 3 },
                new ProductsInDepartment { ProductID = 9, DepartmentID = 3 },
                new ProductsInDepartment { ProductID = 10, DepartmentID = 4 },
                new ProductsInDepartment { ProductID = 11, DepartmentID = 4 },
                new ProductsInDepartment { ProductID = 12, DepartmentID = 4 },
                new ProductsInDepartment { ProductID = 13, DepartmentID = 5 },
                new ProductsInDepartment { ProductID = 14, DepartmentID = 5 },
                new ProductsInDepartment { ProductID = 15, DepartmentID = 5 },
                new ProductsInDepartment { ProductID = 16, DepartmentID = 6 },
                new ProductsInDepartment { ProductID = 17, DepartmentID = 6 },
                new ProductsInDepartment { ProductID = 18, DepartmentID = 6 }
                );
        }
    }
}
