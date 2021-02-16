using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Abstract
{
    public interface IGame
    {
        public int GameId { get; set; }
        public string GameName { get; set; }
        public double GamePrice { get; set; }
    }
}
