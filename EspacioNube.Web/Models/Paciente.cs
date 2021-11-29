using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EspacioNube.Web.Models
{
    public class Paciente : Persona
    {
        public int NumeroDocumento { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int Genero { get; set; }
        
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [DefaultValue("0000000")]
        public string Celular { get; set; }

        public List<Profesional> Profesionales { get; set; }
    }
}
