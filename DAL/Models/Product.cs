using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Contents { get; set; }
        
        public int Stock { get; set; }
        
        public double Price { get; set; }

        [Column(TypeName = "Date")]
        public DateTime ExpireDate { get; set; }

        [Column(TypeName = "Date")]
        public DateTime InventoryDate { get; set; }

        public int StaffID { get; set; }
        public Staff Staff { get; set; }

        public int? CampaignID { get; set; } 
        public Campaign Campaign { get; set; } 

        public List<ProductsInDepartment> ProductDepartment { get; set; }    
    }
}
