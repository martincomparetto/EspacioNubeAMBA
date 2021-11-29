using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace EspacioNube.Web.Data
{
    public static class ContextSeed
    {
        public static async Task SeedRolesAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            await roleManager.CreateAsync(new IdentityRole("SuperAdmin"));
            await roleManager.CreateAsync(new IdentityRole("Profesional"));
            await roleManager.CreateAsync(new IdentityRole("Paciente"));
        }
    }
}
