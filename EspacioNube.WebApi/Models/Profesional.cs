using System.Collections.Generic;

public class Profesional : Persona
{
    public string Matricula { get; set; }
    public Especialidad Especialidad { get; set; }
    public List<Paciente> Pacientes { get; set; }
}