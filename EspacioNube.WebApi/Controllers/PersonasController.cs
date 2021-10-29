using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

[ApiController]
[Route("[controller]")]
public class PersonasController : ControllerBase
{
    [HttpGet]
    public List<Persona> Get()
    {
        Persona pedro = new Persona();
        pedro.Nombre = "Pedro";
        pedro.Apellido = "Picapiedra";

        Persona cristina = new Persona();
        cristina.Nombre = "Cristina";
        cristina.Apellido = "Perez";

        Persona manuel = new Persona();
        manuel.Nombre = "Manuel";
        manuel.Apellido = "Garcia";

        Persona maria = new Persona();
        maria.Nombre = "Maria";
        maria.Apellido = "Lorca";

        List<Persona> personasDevolver = new List<Persona>();
        personasDevolver.Add(pedro);
        personasDevolver.Add(cristina);
        personasDevolver.Add(manuel);
        personasDevolver.Add(maria);

        return personasDevolver;
    }

    [HttpGet]
    [Route("GetOne")]
    public Persona GetOne()
    {
        Persona maria = new Persona();
        maria.Nombre = "Maria";
        maria.Apellido = "Lorca";

        return maria;
    }

    [HttpPost]
    [Route("Save")]
    public void Save(string nombre, string apellido)
    {
        Persona nuevaPersona = new Persona();
        nuevaPersona.Nombre = nombre;
        nuevaPersona.Apellido = apellido;

        //Despueremos como guardamos esta persona en una base de datos
    }
}