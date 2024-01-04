using GameProject.Business.Abstract;
using GameProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Business.Concrete
{
    internal class CampaignManager : ICampaignService
    {
        public void CreateCampaign(Campaign campaign)
        { 
            Console.WriteLine("Sisteme " + campaign.CampaignName + " adlı kampanya eklendi,indirim oranı: %" +campaign.CampaignDiscountPercent );
        }

        public void DeleteCampaign(Campaign campaign)
        {
            Console.WriteLine("Sisteme " + campaign.CampaignName + " adlı kampanya sistemden silinmiştir");

        }

        public void UpdateCampaign(Campaign campaign)
        {
            Console.WriteLine("Sisteme " + campaign.CampaignName + " adlı kampanya güncellenmiştir,indirim oranı: ");
        }
    }
}
