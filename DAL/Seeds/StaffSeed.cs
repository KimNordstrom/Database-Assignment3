using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Seeds
{
    public static class StaffSeed
    {
        public static void StaffSeeder(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Staff>().HasData(
                new Staff
                {
                    StaffID = 1,
                    Name = "John A",
                    PersonalNumber = "19680413-5436",
                    PhoneNumber = "070-5002138",
                    MentorID = null,
                    EndDate = null
                },
                new Staff
                {
                    StaffID = 2,
                    Name = "Bob B",
                    PersonalNumber = "19531030-8564",
                    PhoneNumber = "078-3219543",
                    MentorID = null,
                    EndDate = null
                },
                new Staff
                {
                    StaffID = 3,
                    Name = "Anna H",
                    PersonalNumber = "20010121-9451",
                    PhoneNumber = "076-8659302",
                    MentorID = 1,
                    EndDate = new(2022, 04, 15)
                },
                new Staff
                {
                    StaffID = 4,
                    Name = "Carl N",
                    PersonalNumber = "19980715-7203",
                    PhoneNumber = "076-3246012",
                    MentorID = 2,
                    EndDate = new(2022, 08, 10)
                },
                new Staff
                {
                    StaffID = 5,
                    Name = "Sarah W",
                    PersonalNumber = "19921003-3241",
                    PhoneNumber = "075-5346295",
                    MentorID = 2,
                    EndDate = new(2022, 09, 20)
                });
        }
    }
}
