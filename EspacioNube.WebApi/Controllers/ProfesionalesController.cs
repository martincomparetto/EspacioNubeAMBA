using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class ProfesionalesController : ControllerBase
{
    [HttpGet]
    [Route("Guardar")]
    public void Guardar(string nombre, string apellido, string matricula)
    {
        Profesional nuevoProfesional = new Profesional()
        {
            Nombre = nombre,
            Apellido = apellido,
            Matricula = matricula
        };
        EspacioNube.WebApi.Program.ProfesionalesDB.Add(nuevoProfesional);
    }

    [HttpGet]
    [Route("Todos")]
    public List<Profesional> GetAll()
    {
        return EspacioNube.WebApi.Program.ProfesionalesDB;
    }
}