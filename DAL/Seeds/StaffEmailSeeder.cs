using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Seeds
{
    public static class StaffEmailSeed
    {
        public static void StaffEmailSeeder(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StaffEmail>().HasData(
                new StaffEmail
                {
                    EmailID = 1,
                    Email = "MrA@hotmail.com",
                    StaffID = 1
                },
                new StaffEmail
                {
                    EmailID = 2,
                    Email = "JohnTheBoss@hotmail.com",
                    StaffID = 1
                },
                new StaffEmail
                {
                    EmailID = 3,
                    Email = "bobbyb@gmail.com",
                    StaffID = 2
                },
                new StaffEmail
                {
                    EmailID = 4,
                    Email = "Anna2001@gmail.com",
                    StaffID = 3
                },
                new StaffEmail
                {
                    EmailID = 5,
                    Email = "Carlster98@outlook.com",
                    StaffID = 4
                },
                new StaffEmail
                {
                    EmailID = 6,
                    Email = "Carl_N@outlook.com",
                    StaffID = 4
                },
                new StaffEmail
                {
                    EmailID = 7,
                    Email = "Sarah.W@live.com",
                    StaffID = 5
                }) ;
        }
    }
}
