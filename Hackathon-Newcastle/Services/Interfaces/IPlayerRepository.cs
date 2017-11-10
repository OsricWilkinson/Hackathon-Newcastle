using Hackathon_Newcastle.Entities;
using System;
using System.Collections.Generic;

namespace Hackathon_Newcastle.Services
{
    public interface IPlayerRepository
    {
        IEnumerable<Player> GetPlayer();
        Player GetPlayer(Guid playerId);
        IEnumerable<Player> GetPlayers(IEnumerable<Guid> playerId);
        void AddPlayer(Player player);
        void DeletePlayer(Player player);
        void UpdatePlayer(Player player);
        bool PlayerExists(Guid playerId);
        bool Save();
    }
}
