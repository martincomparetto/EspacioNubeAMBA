using System;

namespace EspacioNube.Web.Models
{
    public class Especialidad
    {
        public Guid ID { get; set; }
        public string Denominacion { get; set; }
        public bool Inactivo { get; set; }
    }
}