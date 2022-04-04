using System;
using System.Linq;

namespace Mission13.Models
{
    public interface IBowlersRepository
    {
        IQueryable<Bowler> Bowlers { get; }

        public void SaveChanges(Bowler b);

        public void AddBowler(Bowler b);

        public void DeleteBowler(Bowler b);

        public void UpdateBowler(Bowler b);

    }
}
