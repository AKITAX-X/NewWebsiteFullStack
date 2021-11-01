using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace VerbindingDatabase
{
    public class KlantContext : DbContext
    {
        public KlantContext(DbContextOptions abc) : base(abc) { }
        public DbSet<Klant> KlantenContext { get; set; }
    }
}
