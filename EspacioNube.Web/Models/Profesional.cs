using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EspacioNube.Web.Models
{
    public class Profesional : EntityBase
    {
        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Apellido { get; set; }

        public string Matricula { get; set; }

        [Required]
        public int EspecialidadID { get; set; }

        [ForeignKey("EspecialidadID")]
        public Especialidad Especialidad { get; set; }
    }
}