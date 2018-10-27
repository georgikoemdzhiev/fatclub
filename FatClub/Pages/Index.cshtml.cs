using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FatClub.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace FatClub.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            Measurements = _context.Measurement.Include(x => x.User).ToList();
        }

        [BindProperty]
        public List<Measurement> Measurements { get; set; }
    }
}
