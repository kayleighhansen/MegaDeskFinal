using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MegaDeskFinal.Models;

namespace MegaDeskFinal.Pages.DeskQuotes
{
    public class CreateModel : PageModel
    {
        private readonly MegaDeskFinalContext _context;

        public CreateModel(MegaDeskFinalContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["DeskId"] = new SelectList(_context.Desk, "DeskId", "DeskId");
        ViewData["ShippingTypeId"] = new SelectList(_context.Set<ShippingType>(), "ShippingTypeId", "ShippingTypeId");
            return Page();
        }

        [BindProperty]
        public DeskQuote DeskQuote { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.DeskQuote.Add(DeskQuote);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
