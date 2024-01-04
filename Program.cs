using GameProject.Business.Abstract;
using GameProject.Business.Concrete;
using GameProject.Entities.Concrete;
using System;

namespace GameProject // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Game game1 = new Game();
            Game game2 = new Game();
            Person user1 = new User();
            List<Game> games = new List<Game>() { game1, game2 };
            IUserValidationService userValidationService = new ValidationManager();
            IAuthService authService = new AuthManager(userValidationService);
            ISaleService saleGame = new SaleManager();  
            ICampaignService campaignService = new CampaignManager();
            

            Campaign campaign1 = new Campaign();
            campaign1.CampaignId = 1;
            campaign1.CampaignName = "Yılbaşı İndirimi Kampanyası";
            campaign1.CampaignDiscountPercent = 90;

            

            game1.GameName = "GTA VI";
            game2.GameName = "VALORANT";
            
            user1.Id = 1;
            user1.FirstName = "Metehan";
            user1.LastName = "Mete";
            user1.IdentityNum = "12345";
            
         

            
                authService.Register(user1);
                campaignService.CreateCampaign(campaign1);
                saleGame.SaleGame(user1, games);
            

        }
    }
}