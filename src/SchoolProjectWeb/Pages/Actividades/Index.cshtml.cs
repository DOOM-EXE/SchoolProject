using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SchoolProjectWeb.Data;
using SchoolProjectWeb.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SchoolProjectWeb.Pages.Actividades
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Actividad> Actividades { get; set; }

        public async Task OnGetAsync()
        {
            Actividades = await _context.Actividades
                .Include(a => a.Profesor)
                .ToListAsync();
        }
    }
}
