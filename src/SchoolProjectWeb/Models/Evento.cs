namespace SchoolProjectWeb.Models
{
    public class Evento
    {
        public int Id { get; set; }
        public string NombreEvento { get; set; }
        public int ActividadId { get; set; }
        public Actividad Actividad { get; set; }
        public DateTime Fecha { get; set; }
        public string Lugar { get; set; }
        public string Descripcion { get; set; }
    }
}
