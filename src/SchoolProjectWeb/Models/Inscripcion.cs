namespace SchoolProjectWeb.Models
{
    public class Inscripcion
    {
        public int Id { get; set; }
        public int EstudianteId { get; set; }
        public Estudiante Estudiante { get; set; }
        public int ActividadId { get; set; }
        public Actividad Actividad { get; set; }
        public DateTime FechaInscripcion { get; set; }
    }
}
