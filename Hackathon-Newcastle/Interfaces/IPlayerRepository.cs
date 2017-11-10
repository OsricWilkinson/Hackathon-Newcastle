using Hackathon_Newcastle.Models;
using System;
using System.Collections.Generic;

namespace Hackathon_Newcastle.Interfaces
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
