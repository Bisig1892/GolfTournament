using GolfTournament.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GolfTournament.Data
{
    public class TournamentContext : DbContext
    {
        public TournamentContext(DbContextOptions<TournamentContext> options) : base(options)
        {
        }

        public DbSet<Tournament> Tournaments { get; set; }
    }
}
