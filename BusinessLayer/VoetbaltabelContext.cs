using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    class VoetbaltabelContext : DbContext
    {

        public DbSet<Player> Players { get; set; }
        public DbSet<Match> Matches { get; set; }
    }
}
