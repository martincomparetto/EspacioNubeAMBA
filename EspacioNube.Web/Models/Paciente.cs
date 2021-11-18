using System;
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
        
        public string Celular { get; set; }
    }
}
