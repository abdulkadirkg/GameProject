using Game.Abstract;
using Game.Adapters;
using Game.Concrete;
using Game.Entities;
using System;
using System.Collections.Generic;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player {
                PlayerId = 1,
                PlayerName = "Abdulkadir",
                PlayerSurname = "KG",
                PlayerTC = "1234567890"
            };
            Player player2 = new Player
            {
                PlayerId = 2,
                PlayerName = "Jeam",
                PlayerSurname = "Carrey",
                PlayerTC = "1234567892"
            };
            Player player3 = new Player
            {
                PlayerId = 3,
                PlayerName = "Durali",
                PlayerSurname = "Durmuş",
                PlayerTC = "2234567892"
            };

            List<ICheckService> checkServices = new List<ICheckService> {
                //new EDevletCheckAdapter() { }, 
                new OwnCheckManager() { }
            };
            PlayerManager playerManager = new PlayerManager(checkServices) ;
            Console.WriteLine("--------------ADD---------------\n");

            playerManager.Add(player);
            playerManager.Add(player2);
            playerManager.Add(player3);

            Console.WriteLine("\n------BEFORE UPDATE GET ALL-----\n");

            List<Player> list; ;
            list = playerManager.GetAll();
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i].PlayerName+" IS IN LIST");
            }

            Console.WriteLine("\n-------------UPDATE-------------\n");

            Player newData = new Player {
                PlayerId = 2,
                PlayerName = "Jim",
                PlayerSurname = "Carrey",
                PlayerTC = "1234567892"
            };
            playerManager.Update(ref player2,newData);

            Console.WriteLine("\n------AFTER UPDATE GET ALL------\n");

            list = playerManager.GetAll();
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i].PlayerName + " IS IN LIST");
            }

            Console.WriteLine("\n-------------DELETE-------------\n");

            playerManager.Delete(player2);

            Console.WriteLine("\n------AFTER DELETE GET ALL------\n");

            list = playerManager.GetAll();
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i].PlayerName + " IS IN LIST");
            }

            Console.WriteLine("\n------------GAME SALE-----------\n");

            Entities.Game game = new Entities.Game();
            game.GameId = 1;
            game.GameName = "Counter Strike";
            game.GamePrice = 25.00;


            SaleManager saleManager = new SaleManager();
            saleManager.Sale(game, player);

            Console.WriteLine("\n------------CAMPAIGN------------\n");
            Campaign campaign = new Campaign {
                CampaignId = 1,
                CampaignName = "Bayram İndirimi",
                CampaignDiscountRate = 10,
                CampaignInfo = "Kurban bayramına özel oyunlarda %10 indirim"
            };
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign);
            Console.WriteLine("\n------SALE DISCOUNTED GAME------\n");
            saleManager.Sale(game, player2,campaign);
        }
    }
}
