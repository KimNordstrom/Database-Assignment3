using DAL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class EmployeeService
    {
        private static EmployeeService _instance;
        public static EmployeeService Instance 
        { 
            get 
            { 
                if (_instance == null)
                { 
                    _instance = new EmployeeService(); 
                } 
                return _instance;
            } 
        }
        private EmployeeService() { }

        public List<Staff> GetEmployees()
        {
            using(var context = new StoreContext())
            {
                return context.Staffs
                    .Include(s => s.Departments)
                    .ToList();
            }
        }
    }
}
