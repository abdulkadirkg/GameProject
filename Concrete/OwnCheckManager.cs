using Game.Abstract;
using Game.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Concrete
{
    public class OwnCheckManager : ICheckService
    {
        public bool CheckPlayer(Player player)
        {
            Console.WriteLine("Kendi Servisimiz'den Doğrulanıyor...");
            Console.WriteLine("DOĞRULAMA BAŞARILI");
            return true;
        }
    }
}
