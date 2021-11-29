using System;
using System.Collections.Generic;
using System.Linq;
using EspacioNube.Web.Data;
using EspacioNube.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EspacioNube.Web.Controllers
{
    [Authorize(Roles = "SuperAdmin, Profesional")]
    public class PacientesController : Controller
    {
        private ApplicationDbContext _context;

        public PacientesController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Crear()
        {
            return View();
        }

        public IActionResult Guardar(string nombre, string apellido, int numerodocumento, DateTime fechanacimiento, int genero, string email, string celular)
        {
            Paciente nuevoPaciente = new Paciente()
            {
                Nombre = nombre,
                Apellido = apellido,
                NumeroDocumento = numerodocumento,
                FechaNacimiento = fechanacimiento,
                Genero = genero,
                Email = email,
                Celular = celular
            }; 
            
            try
            {
                _context.Pacientes.Add(nuevoPaciente);
                _context.SaveChanges();

                ViewBag.Error = "";
                
                return RedirectToAction("Index");
            }
            catch (Exception error)
            {
                ViewBag.Error = error.Message;
                return View("Crear", nuevoPaciente);
            }
        }
    }
}