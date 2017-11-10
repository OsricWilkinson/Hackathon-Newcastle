using Hackathon_Newcastle.Interfaces;
using Hackathon_Newcastle.Models;
using System;
using System.Collections.Generic;

namespace Hackathon_Newcastle.Repositories
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
