using Game.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Abstract
{
    interface ICampaignManager
    {
        void Add(Campaign campaign);
        string GetCampaignInfo(Campaign campaign);
    }
}
