using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Seeds
{
    public static class CampaignSeed
    {
        public static void CampaignSeeder(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Campaign>().HasData(
                new Campaign { CampaignID = 1, Name = "BBQ Weekend", PercentOfPrice = 20 },
                new Campaign { CampaignID = 2, Name = "Breakfast Sale", PercentOfPrice = 15 },
                new Campaign { CampaignID = 3, Name = "Healthy Week", PercentOfPrice = 25 }
                );
        }
    }
}
