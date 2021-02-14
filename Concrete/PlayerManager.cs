using Game.Abstract;
using Game.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Concrete
{
    public class PlayerManager : IPlayer
    {
        readonly List<Player> list = new List<Player>();
        private ICheckService _checkService;
        private List<ICheckService> _checkServices;
        public PlayerManager(ICheckService checkService)
        {
            _checkService = checkService;
        }

        public PlayerManager(List<ICheckService> checkServices)
        {
            _checkServices = checkServices;
        }

        public void Add(Player player)
        {
            for (int i = 0; i < _checkServices.Count; i++)
            {
                if (_checkServices[i].CheckPlayer(player))
                {
                    list.Add(player);
                    Console.WriteLine(player.PlayerName + " Added");
                }
                else
                {
                    Console.WriteLine(player.PlayerName + " INVALID PLAYER");
                    //throw new Exception("DOĞRULAMA BAŞARISIZ!");
                }

            }
                
        }

        public void Delete(Player player)
        {
            list.Remove(player);
            Console.WriteLine(player.PlayerName + " Deleted");
        }

        public void Update(ref Player oldData, Player newData)
        {
            Player data = oldData;
            int index = list.FindIndex(p => p.PlayerId == data.PlayerId);
            list[index] = newData;
            Console.WriteLine(oldData.PlayerName + " Updated to " + newData.PlayerName);
            oldData = newData;
        }

        public List<Player> GetAll()
        {
            return list;
        }
    }
}
