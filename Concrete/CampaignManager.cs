using Game.Abstract;
using Game.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Concrete
{
    public class CampaignManager : ICampaignManager
    {
        List<Campaign> campaignList = new List<Campaign>();

        public void Add(Campaign campaign)
        {
            campaignList.Add(campaign);
            Console.WriteLine(campaign.CampaignName + " Added");
        }

        public List<Campaign> GetAll()
        {
            return campaignList;
        }

        public string GetCampaignInfo(Campaign campaign)
        {
            return campaign.CampaignInfo;
        }
    }
}
