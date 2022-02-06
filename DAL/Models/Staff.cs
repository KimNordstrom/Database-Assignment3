using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Staff
    {
        public int StaffID { get; set; }
        public string Name { get; set; }
        public string PersonalNumber { get; set; }
        public ICollection<StaffEmail> Emails { get; set; }
        public string PhoneNumber { get; set; }

        public int? MentorID { get; set; }
        public Staff Mentor { get; set; }
        public ICollection<Staff> Staffs { get; set; }

        [Column(TypeName = "Date")]
        public DateTime? EndDate { get; set; }

        public ICollection<Product> Products { get; set; }
        public ICollection<Department> Departments { get; set; }
    }
}
