using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SchoolProjectWeb.Data;
using SchoolProjectWeb.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SchoolProjectWeb.Pages.Inscripciones
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Inscripcion> Inscripciones { get; set; }

        public async Task OnGetAsync()
        {
            Inscripciones = await _context.Inscripciones
                .Include(i => i.Estudiante)
                .Include(i => i.Actividad)
                .ToListAsync();
        }
    }
}
