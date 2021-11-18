using System;
using System.ComponentModel.DataAnnotations;

namespace EspacioNube.Web.Models
{
    public abstract class Persona : EntityBase
    {
        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Apellido { get; set; }
    }
}