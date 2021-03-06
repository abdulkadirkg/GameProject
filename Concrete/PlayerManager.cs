﻿using Game.Abstract;
using Game.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Concrete
{
    public class PlayerManager : IPlayerManager
    {
        readonly List<IPlayer> list = new List<IPlayer>();
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

        public void Add(IPlayer player)
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

        public void Delete(IPlayer player)
        {
            list.Remove(list.SingleOrDefault(p => p.PlayerId == player.PlayerId));
            //list.Remove(player); // BU KOD CLASS REFERANS İLE ÇALIŞTIĞI İÇİN DOĞRU ÇALIŞMAZ
            Console.WriteLine(player.PlayerName + " Deleted");
        }

        public void Update(ref IPlayer oldData, IPlayer newData)
        {
            IPlayer data = oldData;
            int index = list.FindIndex(p => p.PlayerId == data.PlayerId);
            list[index] = newData;
            Console.WriteLine(oldData.PlayerName + " Updated to " + newData.PlayerName);
            oldData = newData;
        }

        public List<IPlayer> GetAll()
        {
            return list;
        }
    }
}
