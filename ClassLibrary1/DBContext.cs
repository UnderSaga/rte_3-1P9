using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class DBContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Special> Specials { get; set; }
        public DbSet<Grop> Grops { get; set; }
    }
}
