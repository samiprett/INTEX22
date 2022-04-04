using System;
using Microsoft.EntityFrameworkCore;

namespace Mission13.Models
{
    public class BowlingLeagueDbContext : DbContext
    {
        //constructor
        public BowlingLeagueDbContext(DbContextOptions<BowlingLeagueDbContext> options) : base (options)
        {

        }

        public DbSet<Bowler> Bowlers { get; set; }
    }
}
