using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MegaDeskFinal.Models;

namespace MegaDeskFinal.Pages.DeskQuotes
{
    public class IndexModel : PageModel
    {
        private readonly MegaDeskFinalContext _context;

        public IndexModel(MegaDeskFinalContext context)
        {
            _context = context;
        }

        public IList<DeskQuote> DeskQuote { get;set; }

        public async Task OnGetAsync()
        {
            DeskQuote = await _context.DeskQuote
                .Include(d => d.Desk)
                .Include(d => d.ShippingType).ToListAsync();
        }
    }
}
