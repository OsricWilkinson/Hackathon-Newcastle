﻿using Hackathon_Newcastle.Interfaces;
using Hackathon_Newcastle.Models;
using System;
using System.Collections.Generic;

namespace Hackathon_Newcastle.Repositories
{
    public class ShotRepository : IShotRepository
    {
        public void AddShot(Shot shot)
        {
            throw new NotImplementedException();
        }

        public void DeleteShot(Shot shot)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Shot> GetShot()
        {
            throw new NotImplementedException();
        }

        public Shot GetShot(Guid shotId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Shot> GetShots(IEnumerable<Guid> shotId)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }

        public bool ShotExists(Guid shotId)
        {
            throw new NotImplementedException();
        }

        public void UpdateShot(Shot shot)
        {
            throw new NotImplementedException();
        }
    }
}
