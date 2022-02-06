using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Department
    {
        public int DepartmentID { get; set; }
        public string Name { get; set; }

        public int StaffID { get; set; } 
        public Staff Staff { get; set; }

        public List<ProductsInDepartment> ProductDepartment { get; set; }  
    }
}
