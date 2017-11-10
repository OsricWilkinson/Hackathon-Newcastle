using Hackathon_Newcastle.Entities;
using System;
using System.Collections.Generic;

namespace Hackathon_Newcastle.Services
{
    public class PlayerRepository : IPlayerRepository
    {
        public void AddPlayer(Player player)
        {
            throw new NotImplementedException();
        }

        public void DeletePlayer(Player player)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Player> GetPlayer()
        {
            throw new NotImplementedException();
        }

        public Player GetPlayer(Guid playerId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Player> GetPlayers(IEnumerable<Guid> playerId)
        {
            throw new NotImplementedException();
        }

        public bool PlayerExists(Guid playerId)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }

        public void UpdatePlayer(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
