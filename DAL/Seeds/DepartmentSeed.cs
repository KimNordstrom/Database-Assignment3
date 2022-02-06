using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Seeds
{
    public static class DepartmentSeed
    {
        public static void DepartmentSeeder(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentID = 1, Name = "Dairy", StaffID = 3 },
                new Department { DepartmentID = 2, Name = "Bread", StaffID = 2 },
                new Department { DepartmentID = 3, Name = "Meat", StaffID = 2 },
                new Department { DepartmentID = 4, Name = "Drink", StaffID = 1 },
                new Department { DepartmentID = 5, Name = "Fruit", StaffID = 4 },
                new Department { DepartmentID = 6, Name = "Pantry", StaffID = 1 });

        }
    }
}
