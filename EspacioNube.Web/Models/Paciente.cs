using System;

namespace EspacioNube.Web.Models
{
    public class Paciente : Persona
    {
        public int NumeroDocumento { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int Genero { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
    }
}
