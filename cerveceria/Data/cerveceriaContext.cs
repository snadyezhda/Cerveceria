using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using cerveceria.Models;

namespace cerveceria.Data
{
    public class cerveceriaContext : DbContext
    {
        public cerveceriaContext (DbContextOptions<cerveceriaContext> options)
            : base(options)
        {
        }

        public DbSet<cerveceria.Models.Persona> Persona { get; set; }

        public DbSet<cerveceria.Models.Productos> Productos { get; set; }
    }
}
