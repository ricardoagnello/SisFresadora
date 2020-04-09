using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SisFresadora.Models;

namespace SisFresadora.Data
{
    public class SisFresadoraContext : DbContext
    {
        public SisFresadoraContext (DbContextOptions<SisFresadoraContext> options)
            : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Servico> Servicos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().ToTable("Cliente");
            modelBuilder.Entity<Servico>().ToTable("Servico");
        }
        
    }
}
