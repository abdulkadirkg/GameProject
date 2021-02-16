using Game.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Abstract
{
    public interface IPlayerManager
    {
        void Add(IPlayer player);
        void Update(ref IPlayer oldData, IPlayer newData);
        void Delete(IPlayer player);
    }
}
