using Game.Abstract;
using Game.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Concrete
{
    public class CampaignManager : ICampaignManager
    {
        List<ICampaign> campaignList = new List<ICampaign>();

        public void Add(ICampaign campaign)
        {
            campaignList.Add(campaign);
            Console.WriteLine(campaign.CampaignName + " Added");
        }

        public List<ICampaign> GetAll()
        {
            return campaignList;
        }

        public string GetCampaignInfo(ICampaign campaign)
        {
            return campaign.CampaignInfo;
        }
    }
}
