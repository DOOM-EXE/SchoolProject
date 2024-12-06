using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SchoolProjectWeb.Data;
using SchoolProjectWeb.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SchoolProjectWeb.Pages.Eventos
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Evento> Eventos { get; set; }

        public async Task OnGetAsync()
        {
            // Cargar los eventos junto con sus actividades relacionadas
            Eventos = await _context.Eventos
                .Include(e => e.Actividad)
                .ToListAsync();
        }
    }
}
