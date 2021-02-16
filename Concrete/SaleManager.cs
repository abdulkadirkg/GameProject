using Game.Abstract;
using Game.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Concrete
{
    public class SaleManager : ISaleManager
    {
        private ICampaign _campaign;
        public SaleManager(ICampaign campaign = null)
        {
            _campaign = campaign;
        }

        public void Sale(IGame game, IPlayer player, ICampaign campaign = null)
        {
            if (campaign != null)
            {
                Console.WriteLine("Uygulanan İndirim: " + campaign.CampaignName);
                Console.WriteLine(campaign.CampaignInfo);
                game.GamePrice *= (100 - campaign.CampaignDiscountRate) / 100;
            }
            Console.WriteLine(player.PlayerName + " Oyuncusu " + game.GameName + " Oyununu "+ game.GamePrice+" TL'ye Satın Aldı.");
        }
    }
}
