using Game.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Abstract
{
    public interface ISaleManager
    {
        public void Sale(IGame game, IPlayer player, ICampaign campaign = null);
    }
}
