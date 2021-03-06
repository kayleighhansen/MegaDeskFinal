using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MegaDeskFinal.Models;
using MegaDeskFinal.Data;

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
            ViewData["ShippingTypeId"] = new SelectList(_context.Set<ShippingType>(), "ShippingTypeId", "ShippingTypeName");
            ViewData["DesktopMaterialId"] = new SelectList(_context.Set<DesktopMaterial>(), "DesktopMaterialId", "DesktopMaterialName");
            return Page();
        }

        [BindProperty]
        public DeskQuote DeskQuote { get; set; }

        [BindProperty]
        public Desk Desk { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Desk.Add(Desk);
            await _context.SaveChangesAsync();

            DeskQuote.DeskId = Desk.DeskId;

            DeskQuote.Desk = Desk;

            DeskQuote.DateCreated = DateTime.Now;
            
            DeskQuote.QuotePrice = DeskQuote.GetQuotePrice(_context);

            _context.DeskQuote.Add(DeskQuote);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
