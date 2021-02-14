using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Abstract
{
    public interface ICampaign
    {
        public int CampaignId { get; set; }
        public string CampaignName { get; set; }
        public string CampaignInfo { get; set; }
        public double CampaignDiscountRate { get; set; }
    }
}
