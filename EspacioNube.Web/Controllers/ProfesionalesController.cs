using EspacioNube.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace EspacioNube.Web.Controllers
{
    public class ProfesionalesController : Controller
    {
        public IActionResult Index()
        {
            return View(Program.ProfesionalesList);
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Guardar(string nombre, string apellido, int especialidadID)
        {
            Especialidad especilidadSeleccionada = Program.EspecialidadesList.Find(e => e.ID == especialidadID);
            Profesional nuevo = new Profesional() {
                ID = Program.ProfesionalesList.Count + 1,
                Nombre = nombre,
                Apellido = apellido,
                EspecialidadID = especialidadID,
                Especialidad = especilidadSeleccionada
            };
            Program.ProfesionalesList.Add(nuevo);
            return RedirectToAction("Index");
        }
    }
}