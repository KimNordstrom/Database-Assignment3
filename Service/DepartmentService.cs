using DAL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class DepartmentService
    {
        private static DepartmentService _instance;
        public static DepartmentService Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DepartmentService();
                }
                return _instance;
            }
        }
        private DepartmentService() { }

        public List<Department> GetDepartmentAndEmail()
        {
            using (var context = new StoreContext())
            {
                return context.Departments
                .Include(d => d.Staff.Emails)
                .ToList();
            }
        }
    }
}
