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

        public DbSet<SisFresadora.Models.Cliente> Cliente { get; set; }
    }
}
