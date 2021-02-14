using Game.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Entities
{
    public class Player : IPlayer
    {
        public int PlayerId { get; set; }
        public string PlayerTC { get; set; }
        public string PlayerName { get; set; }
        public string PlayerSurname { get; set; }
        public DateTime BirthOfDate { get; set; }
    }
}
