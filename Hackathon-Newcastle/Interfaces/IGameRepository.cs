using Hackathon_Newcastle.Models;
using System;
using System.Collections.Generic;

namespace Hackathon_Newcastle.Interfaces
{
    public interface IGameRepository
    {
        IEnumerable<Game> GetGame();
        Game GetGame(Guid gameId);
        IEnumerable<Game> GetGames(IEnumerable<Guid> gameId);
        void AddGame(Game game);
        void DeleteGame(Game game);
        void UpdateGame(Game game);
        bool GameExists(Guid gameId);
        bool Save();
    }
}
