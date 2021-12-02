using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EspacioNube.Web.Models
{
    public class Profesional : Persona
    {
        public string Matricula { get; set; }

        [Required]
        [Display(Name = "Especialidad")]
        public int EspecialidadID { get; set; }

        [ForeignKey("EspecialidadID")]
        public Especialidad Especialidad { get; set; }

        public string UsuarioID { get; set; }

        [ForeignKey("UsuarioID")]
        public ApplicationUser Usuario { get; set; }

        public List<Paciente> Pacientes { get; set; }
    }
}