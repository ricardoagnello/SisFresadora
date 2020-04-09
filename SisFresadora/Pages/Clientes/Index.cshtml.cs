using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SisFresadora.Data;
using SisFresadora.Models;

namespace SisFresadora.Pages.Clientes
{
    public class IndexModel : PageModel
    {
        private readonly SisFresadora.Data.SisFresadoraContext _context;

        public IndexModel(SisFresadora.Data.SisFresadoraContext context)
        {
            _context = context;
        }

        public IList<Cliente> Cliente { get;set; }

        public async Task OnGetAsync()
        {
            Cliente = await _context.Clientes.ToListAsync();
        }
    }
}
