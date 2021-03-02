using GolfTournament.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GolfTournament.Data
{
    public class TournamentContext : IdentityDbContext
    {
        public TournamentContext(DbContextOptions<TournamentContext> options)
            : base(options)
        {
        }
        public DbSet<Tournaments> Tournaments { get; set; }
    }
}
