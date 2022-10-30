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
    public class IndexModel : PageModel
    {
        private readonly Crisan_Iulia_lab2.Data.Crisan_Iulia_lab2Context _context;

        public IndexModel(Crisan_Iulia_lab2.Data.Crisan_Iulia_lab2Context context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; } = default!;

        public async Task OnGetAsync()
        {
            
            
                Book = await _context.Book
                .Include(b=>b.Publisher)
                .ToListAsync();
                
            
        }
    }
}
