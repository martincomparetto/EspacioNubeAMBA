using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class EspecialidadesController : ControllerBase
{
    [HttpGet]
    [Route("Guardar")]
    public void Guardar(string denominacion)
    {
        Especialidad nuevaEspecialidad = new Especialidad();
        nuevaEspecialidad.Denominacion = denominacion;

        EspacioNube.WebApi.Program.EspecialidadesDB.Add(nuevaEspecialidad);
    }

    [HttpGet]
    [Route("Todos")]
    public List<Especialidad> GetAll()
    {
        return EspacioNube.WebApi.Program.EspecialidadesDB;
    }
}