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
    public class DetailsModel : PageModel
    {
        private readonly SisFresadora.Data.SisFresadoraContext _context;

        public DetailsModel(SisFresadora.Data.SisFresadoraContext context)
        {
            _context = context;
        }

        public Cliente Cliente { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Cliente = await _context.Clientes.FirstOrDefaultAsync(m => m.ID == id);

            if (Cliente == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
