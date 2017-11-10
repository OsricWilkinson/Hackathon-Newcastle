using Hackathon_Newcastle.Entities;
using System;
using System.Collections.Generic;

namespace Hackathon_Newcastle.Services
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
