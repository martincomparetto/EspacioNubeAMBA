using Microsoft.AspNetCore.Mvc;

namespace EspacioNube.Web.Controllers
{
    public class EspecialidadesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Saludar(string nombre, string apellido, int repeticion)
        {
            // ViewData["parametroNombre"] = nombre;
            // ViewData["parametroApellido"] = apellido;
            ViewBag.parametroNombre = nombre;
            ViewBag.parametroApellido = apellido;
            ViewBag.repeticion = repeticion;

            return View();
        }
    }
}