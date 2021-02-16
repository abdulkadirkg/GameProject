using Game.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Abstract
{
    public interface ICheckService
    {
        bool CheckPlayer(IPlayer player);
    }
}
