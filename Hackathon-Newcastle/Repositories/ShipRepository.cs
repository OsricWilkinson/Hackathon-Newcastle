﻿using Hackathon_Newcastle.Interfaces;
using Hackathon_Newcastle.Models;
using System;
using System.Collections.Generic;

namespace Hackathon_Newcastle.Repositories
{
    public class ShipRepository : IShipRepository
    {
        public void AddShip(Ship ship)
        {
            throw new NotImplementedException();
        }

        public void DeleteShip(Ship ship)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Ship> GetShip()
        {
            throw new NotImplementedException();
        }

        public Ship GetShip(Guid shipId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Ship> GetShips(IEnumerable<Guid> shipId)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }

        public bool ShipExists(Guid shipId)
        {
            throw new NotImplementedException();
        }

        public void UpdateShip(Ship ship)
        {
            throw new NotImplementedException();
        }
    }
}
