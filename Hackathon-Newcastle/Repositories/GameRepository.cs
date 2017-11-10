using Hackathon_Newcastle.Interfaces;
using Hackathon_Newcastle.Models;
using System;
using System.Collections.Generic;

namespace Hackathon_Newcastle.Repositories
{
    public class GameRepository : IGameRepository
    {
        public void AddGame(Game game)
        {
            throw new NotImplementedException();
        }

        public void DeleteGame(Game game)
        {
            throw new NotImplementedException();
        }

        public bool GameExists(Guid gameId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Game> GetGame()
        {
            throw new NotImplementedException();
        }

        public Game GetGame(Guid gameId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Game> GetGames(IEnumerable<Guid> gameId)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }

        public void UpdateGame(Game game)
        {
            throw new NotImplementedException();
        }
    }
}
