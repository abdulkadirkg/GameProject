using Game.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Abstract
{
    public interface IPlayerManager
    {
        void Add(Player player);
        void Update(ref Player oldData, Player newData);
        void Delete(Player player);
    }
}
