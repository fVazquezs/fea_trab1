using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using fea_trab1.Models;

namespace fea_trab1.Models
{
    public class Context : DbContext
    {
        public Context (DbContextOptions<Context> options)
            : base(options)
        {
        }

        public DbSet<fea_trab1.Models.User> User { get; set; }

        public DbSet<fea_trab1.Models.Category> Category { get; set; }

        public DbSet<fea_trab1.Models.Product> Product { get; set; }
    }
}
