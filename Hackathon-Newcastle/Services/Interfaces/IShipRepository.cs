using Hackathon_Newcastle.Entities;
using System;
using System.Collections.Generic;

namespace Hackathon_Newcastle.Services
{
    public interface IShipRepository
    {
        IEnumerable<Ship> GetShip();
        Ship GetShip(Guid shipId);
        IEnumerable<Ship> GetShips(IEnumerable<Guid> shipId);
        void AddShip(Ship ship);
        void DeleteShip(Ship ship);
        void UpdateShip(Ship ship);
        bool ShipExists(Guid shipId);
        bool Save();
    }
}
