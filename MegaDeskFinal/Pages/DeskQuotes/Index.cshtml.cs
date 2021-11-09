using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MegaDeskFinal.Models;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace MegaDeskFinal.Pages.DeskQuotes
{
    public class IndexModel : PageModel
    {
        private readonly MegaDeskFinalContext _context;

        public IndexModel(MegaDeskFinalContext context)
        {
            _context = context;
        }

        public IList<DeskQuote> DeskQuote { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }




        public async Task OnGetAsync()
        {
            var deskQuotes = from d in _context.DeskQuote
                             select d;
            if (!string.IsNullOrEmpty(SearchString))
            {
                deskQuotes = deskQuotes.Where(s => s.CustomerName.Contains(SearchString));
            }

            DeskQuote = await _context.DeskQuote
                .Include(d => d.Desk)
                .Include(d => d.ShippingType).ToListAsync();

            DeskQuote = await deskQuotes.ToListAsync();
        }
    }
}
