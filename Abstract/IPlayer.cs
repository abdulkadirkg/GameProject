using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Abstract
{
    public interface IPlayer
    {
        public int PlayerId { get; set; }
        public string PlayerTC { get; set; }
        public string PlayerName { get; set; }
        public string PlayerSurname { get; set; }
        public DateTime BirthOfDate { get; set; }
    }
}
