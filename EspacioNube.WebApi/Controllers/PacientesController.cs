using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

[ApiController]
[Route("[controller]")]
public class PacientesController : ControllerBase
{
    [HttpGet]
    public List<Paciente> Get()
    {
        List<Paciente> listaDevolver = new List<Paciente>();

        Paciente paciente1 = new Paciente();
        paciente1.Nombre = "Petter";
        paciente1.Apellido = "Parker";
        paciente1.DNI = 35678963;

        Paciente cristina = new Paciente();
        cristina.Nombre = "Cristina";
        cristina.Apellido = "Perez";
        cristina.DNI = 36554665;

        listaDevolver.Add(paciente1);
        listaDevolver.Add(cristina);

        return listaDevolver;
    }
}