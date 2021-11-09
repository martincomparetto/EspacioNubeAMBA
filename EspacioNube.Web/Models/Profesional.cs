namespace EspacioNube.Web.Models
{
    public class Profesional
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int EspecialidadID { get; set; }
        public Especialidad Especialidad { get; set; }
    }
}