using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Abstract
{
    interface IPlayer
    {
        public int PlayerId { get; set; }
        public string PlayerTC { get; set; }
        public string PlayerName { get; set; }
        public string PlayerSurname { get; set; }
        public DateTime BirthOfDate { get; set; }
    }
}
