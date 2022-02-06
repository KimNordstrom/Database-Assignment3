using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Campaign
    {
        public int CampaignID { get; set; }
        public string Name { get; set; }
        public double PercentOfPrice { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
