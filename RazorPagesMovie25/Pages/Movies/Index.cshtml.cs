using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie25.Data;
using RazorPagesMovie25.Models;

namespace RazorPagesMovie25.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesMovie25.Data.RazorPagesMovie25Context _context;

        public IndexModel(RazorPagesMovie25.Data.RazorPagesMovie25Context context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
