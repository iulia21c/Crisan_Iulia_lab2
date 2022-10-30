using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Crisan_Iulia_lab2.Data;
using Crisan_Iulia_lab2.Models;

namespace Crisan_Iulia_lab2.Pages.Books
{
    public class DetailsModel : PageModel
    {
        private readonly Crisan_Iulia_lab2.Data.Crisan_Iulia_lab2Context _context;

        public DetailsModel(Crisan_Iulia_lab2.Data.Crisan_Iulia_lab2Context context)
        {
            _context = context;
        }

      public Book Book { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Book == null)
            {
                return NotFound();
            }

            var book = await _context.Book.FirstOrDefaultAsync(m => m.ID == id);
            if (book == null)
            {
                return NotFound();
            }
            else 
            {
                Book = book;
            }
            return Page();
        }
    }
}
