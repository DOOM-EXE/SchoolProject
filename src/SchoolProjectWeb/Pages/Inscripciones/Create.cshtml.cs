using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SchoolProjectWeb.Data;
using SchoolProjectWeb.Models;

namespace SchoolProjectWeb.Pages_Inscripciones
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public CreateModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Inscripcion Inscripcion { get; set; }

        // Listas de SelectList para Estudiantes y Actividades
        public SelectList Estudiantes { get; set; }
        public SelectList Actividades { get; set; }

        // Acción OnGet para cargar Estudiantes y Actividades en los dropdowns
        public IActionResult OnGet()
        {
            // Inicializa la propiedad FechaInscripcion con la fecha actual
            Inscripcion = new Inscripcion
            {
                FechaInscripcion = DateTime.Now // Asigna la fecha de hoy automáticamente
            };

            // Cargar las listas de Estudiantes y Actividades
            Estudiantes = new SelectList(_context.Estudiantes, "Id", "Nombre");
            Actividades = new SelectList(_context.Actividades, "Id", "NombreActividad");

            return Page();
        }


        // Acción OnPost para guardar la inscripción
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                // Si el modelo no es válido, volver a mostrar la página con los errores de validación
                Estudiantes = new SelectList(_context.Estudiantes, "Id", "Nombre");
                Actividades = new SelectList(_context.Actividades, "Id", "NombreActividad");
                return Page();
            }

            try
            {
                // Agregar la inscripción a la base de datos
                _context.Inscripciones.Add(Inscripcion);
                _context.SaveChanges();
                return RedirectToPage("./Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, $"Error al guardar la inscripción: {ex.Message}");
                Estudiantes = new SelectList(_context.Estudiantes, "Id", "Nombre");
                Actividades = new SelectList(_context.Actividades, "Id", "NombreActividad");
                return Page();
            }
        }
    }
}
