using System;
using System.Linq;
using EspacioNube.Web.Data;
using EspacioNube.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EspacioNube.Web.Controllers
{
    [Authorize]
    public class EspecialidadesController : Controller
    {
        private ApplicationDbContext _context;

        public EspecialidadesController(ApplicationDbContext context)
        {
            _context = context;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            return View(_context.Especialidades.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Guardar(string nombre)
        {
            Especialidad nuevaEspecialidad = new Especialidad();
            nuevaEspecialidad.Denominacion = nombre;

            _context.Especialidades.Add(nuevaEspecialidad);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Editar(int id)
        {
            Especialidad editar = Buscar(id);
            if (editar == null)
            {
                return RedirectToAction("Index");
            }
            return View(editar);
        }

        public IActionResult Actualizar(int id, string nombre)
        {
            Especialidad editar = Buscar(id);
            if (editar != null)
            {
                editar.Denominacion = nombre;
                _context.Especialidades.Update(editar);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        private Especialidad Buscar(int id)
        {
            // Especialidad find = null;
            // foreach (var item in EspacioNube.Web.Program.EspecialidadesList)
            // {
            //     if (item.ID == id)
            //     {
            //         find = item;
            //         break;
            //     }
            // }
            Especialidad find = _context.Especialidades.Find(id);

            return find;
        }
    }
}