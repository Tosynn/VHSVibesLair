using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using VHSVibesLair.Data;
using VHSVibesLair.Models;

namespace VHSVibesLair.Pages.Movies
{
    public class DetailsModel : PageModel
    {
        private readonly VHSVibesLair.Data.VHSVibesLairContext _context;

        public DetailsModel(VHSVibesLair.Data.VHSVibesLairContext context)
        {
            _context = context;
        }

        public Movie Movie { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.Movie.FirstOrDefaultAsync(m => m.Id == id);
            if (movie == null)
            {
                return NotFound();
            }
            else
            {
                Movie = movie;
            }
            return Page();
        }
    }
}
