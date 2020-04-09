using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SisFresadora.Data;
using SisFresadora.Models;

namespace SisFresadora.Pages.Clientes
{
    public class EditModel : PageModel
    {
        private readonly SisFresadora.Data.SisFresadoraContext _context;

        public EditModel(SisFresadora.Data.SisFresadoraContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync( int id)
        {
            var clienteToUpdate = await _context.Clientes.FindAsync(id);
            if (clienteToUpdate == null)
            {
                return NotFound();
            }
            if (await TryUpdateModelAsync<Cliente>(
                clienteToUpdate,
                "cliente",
                c => c.Nome))
            {
                await _context.SaveChangesAsync();
                return RedirectToPage("./Index");
            }

            return Page();

            

           
        }

        private bool ClienteExists(int id)
        {
            return _context.Clientes.Any(e => e.ID == id);
        }
    }
}
