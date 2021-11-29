using System.Collections.Generic;
using System.Linq;
using EspacioNube.Web.Data;
using EspacioNube.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EspacioNube.Web.Controllers
{
    [Authorize(Roles = "SuperAdmin,Profesional")]
    public class ProfesionalesController : Controller
    {
        private ApplicationDbContext _context;
        public ProfesionalesController(ApplicationDbContext context)
        {
            _context = context;
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

        public IActionResult Guardar(string nombre, string apellido, string matricula, int especialidadID)
        {
            Profesional nuevo = new Profesional() {
                Nombre = nombre,
                Apellido = apellido,
                Matricula = matricula,
                EspecialidadID = especialidadID
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