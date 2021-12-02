using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EspacioNube.Web.Data;
using EspacioNube.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EspacioNube.Web.Controllers
{
    [Authorize(Roles = "SuperAdmin,Profesional")]
    public class ProfesionalesController : Controller
    {
        private ApplicationDbContext _context;
        private UserManager<ApplicationUser> _userManager;

        public ProfesionalesController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            List<Profesional> lista = _context.Profesionales.Include("Especialidad").ToList();
            return View(lista);
        }

        public IActionResult Create()
        {
            ViewBag.EspecialidadesList = _context.Especialidades.ToList();

            return View();
        }

        public async Task<IActionResult> GuardarAsync(string nombre, string apellido, string matricula, int especialidadID)
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            Profesional nuevo = new Profesional() {
                Nombre = nombre,
                Apellido = apellido,
                Matricula = matricula,
                EspecialidadID = especialidadID,
                UsuarioID = user.Id
            };
            _context.Profesionales.Add(nuevo);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        [AllowAnonymous]
        public List<Profesional> GetByEspecialidad(int especialidadID)
        {
            return _context.Profesionales.Where(p => p.EspecialidadID == especialidadID).ToList();
        }
    }
}