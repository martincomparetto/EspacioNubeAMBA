using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EspacioNube.Web.Models
{
    public class Especialidad : EntityBase
    {
        [Required]
        public string Denominacion { get; set; }
        
        public bool Inactivo { get; set; }
    }
}