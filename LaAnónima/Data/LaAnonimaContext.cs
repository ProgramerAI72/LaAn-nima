using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LaAnónima.Models;

namespace LaAnonima.Data
{
    public class LaAnonimaContext : DbContext
    {
        public LaAnonimaContext (DbContextOptions<LaAnonimaContext> options)
            : base(options)
        {
        }

        public DbSet<LaAnónima.Models.Pasillo> Pasillo { get; set; } = default!;

        public DbSet<LaAnónima.Models.Producto> Producto { get; set; } = default!;
    }
}
