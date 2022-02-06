using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class ProductsInDepartment
    {
        public int? ProductID { get; set; }  
        public virtual Product Product { get; set; }    
        public int? DepartmentID { get; set; }
        public virtual Department Department { get; set; }  
    }
}
