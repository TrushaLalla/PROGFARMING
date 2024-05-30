using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using progpoe.Data;
using progpoe.Models;

namespace progpoe.Views.Farmers
{
    public class DetailsModel : PageModel
    {
        private readonly progpoe.Data.ApplicationDbContext _context;

        public DetailsModel(progpoe.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Farmer Farmer { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var farmer = await _context.Farmer.FirstOrDefaultAsync(m => m.Id == id);
            if (farmer == null)
            {
                return NotFound();
            }
            else
            {
                Farmer = farmer;
            }
            return Page();
        }
    }
}
