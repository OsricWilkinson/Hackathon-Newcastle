using Hackathon_Newcastle.Entities;
using System;
using System.Collections.Generic;

namespace Hackathon_Newcastle.Services
{
    public interface IShotRepository
    {
        IEnumerable<Shot> GetShot();
        Shot GetShot(Guid shotId);
        IEnumerable<Shot> GetShots(IEnumerable<Guid> shotId);
        void AddShot(Shot shot);
        void DeleteShot(Shot shot);
        void UpdateShot(Shot shot);
        bool ShotExists(Guid shotId);
        bool Save();
    }
}
