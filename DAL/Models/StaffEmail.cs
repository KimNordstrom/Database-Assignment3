using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class StaffEmail
    {
        public int EmailID { get; set; }
        public string Email { get; set; }
        public int StaffID { get; set; }
        public Staff Staff { get; set; }
    }
}
