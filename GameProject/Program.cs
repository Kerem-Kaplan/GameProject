using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer();
            gamer1.id = 1;
            gamer1.Name = "KEREM";
            gamer1.LastName = "KAPLAN";
            gamer1.IdentityNumber = 111111;
            gamer1.YearOfBirth = 2002;



            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(gamer1);

            Campaign campaign = new Campaign();
            campaign.ID = 1;
            campaign.CampaignName = "Yaz Tatili";
            campaign.PercentOfSale = 0.15;

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign);

            Sale sale1 = new Sale();
            sale1.ID = 1;
            sale1.CampaignName = campaign.CampaignName;
            sale1.GameName = "Rocket League";
            sale1.GamerName = gamer1.Name + " " + gamer1.LastName;
            sale1.Price = 42;

            SaleManager saleManager = new SaleManager();
            saleManager.Add(sale1);
        }
    }
}
