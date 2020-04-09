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
    public class DeleteModel : PageModel
    {
        private readonly SisFresadora.Data.SisFresadoraContext _context;

        public DeleteModel(SisFresadora.Data.SisFresadoraContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Cliente Cliente { get; set; }
        public string ErrorMessage { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id, bool? saveChangesError = false)
        {
            if (id == null)
            {
                return NotFound();
            }

            Cliente = await _context.Clientes
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.ID == id);

            if (Cliente == null)
            {
                return NotFound();
            }
            if (saveChangesError.GetValueOrDefault())
            {
                ErrorMessage = "Delete failed. Try again";
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cliente = await _context.Clientes.FindAsync(id);

            if (cliente == null)
            {
                return NotFound();
            }

            try
            {
                _context.Clientes.Remove(cliente);
                await _context.SaveChangesAsync();
                return RedirectToPage("./Index");
            }
            catch( DbUpdateException ex)
            {
                return RedirectToAction(ex.Message);
            }

            

            
        }
    }
}
