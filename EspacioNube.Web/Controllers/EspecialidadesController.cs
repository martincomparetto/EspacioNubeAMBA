using System;
using System.Linq;
using EspacioNube.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace EspacioNube.Web.Controllers
{
    public class EspecialidadesController : Controller
    {
        public IActionResult Index()
        {
            return View(EspacioNube.Web.Program.EspecialidadesList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Guardar(string nombre)
        {
            Especialidad nuevaEspecialidad = new Especialidad();
            nuevaEspecialidad.ID = EspacioNube.Web.Program.EspecialidadesList.Count + 1;
            nuevaEspecialidad.Denominacion = nombre;

            EspacioNube.Web.Program.EspecialidadesList.Add(nuevaEspecialidad);

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
            Especialidad find = EspacioNube.Web.Program.EspecialidadesList.Find(elemento => elemento.ID == id);

            return find;
        }
    }
}