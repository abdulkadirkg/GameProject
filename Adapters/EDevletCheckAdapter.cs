using Game.Abstract;
using Game.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Adapters
{
    class EDevletCheckAdapter : ICheckService
    {
        public bool CheckPlayer(IPlayer player)
        {
            Console.WriteLine("E Devlet'e Bağlanılıyor...");
            if (player.PlayerTC.StartsWith("12345"))
            {
                Console.WriteLine(player.PlayerName+" Doğrulandı.");
                return true;
            }
            else
            {
                Console.WriteLine(player.PlayerName + " Doğrulanamadı.");
                return false;
            }
        }
    }
}
