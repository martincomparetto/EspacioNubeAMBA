using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace EspacioNube.Web
{
    public class ApplicationUser : IdentityUser
    {
        [MaxLength(200)]
        public string Nombre { get; set; }

        [MaxLength(200)]
        public string Apellido { get; set; }
        
        public int NumeroDocumento { get; set; }
        
        public byte[] Foto { get; set; }
    }
}