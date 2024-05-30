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
    public class IndexModel : PageModel
    {
        private readonly progpoe.Data.ApplicationDbContext _context;

        public IndexModel(progpoe.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Farmer> Farmer { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Farmer = await _context.Farmer.ToListAsync();
        }
    }
}
