using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Entities.Concrete
{
    internal class Campaign
    {
        public int CampaignId { get; set; }
        public string CampaignName { get; set;}
        public string CampaignDescription { get; set;}
        public int CampaignDiscountPercent { get; set; }

    }
}
