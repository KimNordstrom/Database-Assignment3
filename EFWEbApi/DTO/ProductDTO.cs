using EFWEbApi.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.DTO
{
    public class ProductDTO
    {
        public string Name { get; set; }
        public int Stock { get; set; }
        public string Status { get; set; }
    }
    public class NewCountDTO
    {
        public int ProductID { get; set; }
        public int NewCount { get; set; }
    }
    public class ProductNameDTO
    {
        public string ProductName { get; set; }
    }

}
