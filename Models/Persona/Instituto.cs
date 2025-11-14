namespace DOOProgram;
/* 
Ejercicio 4 – Gestión educativa
Desarrolle un sistema para registrar las personas de una institución educativa.
Cree la clase padre Persona con Id, Nombre, Edad.
Crear las clases hijas Alumno (con Legajo y Promedio) y Profesor (con Materia y Sueldo).
Extra:
Listado general, diferenciando alumnos y profesores.
*/
public class Persona
{
    protected static int Id { get; set; }
    protected string? Nombre { get; set; }
    protected int Edad { get; set; }
    public Persona() { System.Console.WriteLine("Se ha creado a la persona con exito"); }
    public Persona(string nombre, int edad)
    {
        Random rdm = new Random();
        Id = rdm.Next(1111, 9999);
        Nombre = nombre;
        Edad = edad;
    }
}
public class Alumno : Persona
{
    protected string? Legajo { get; set; }
    protected float Promedio { get; set; }
    public Alumno() : base() { System.Console.WriteLine("Alumno creado..."); }
    public Alumno(string nombre, int edad, string legajo, float promedio) : base(nombre, edad)
    {
        Legajo = legajo;
        Promedio = promedio;
    }
}
public class Profesor : Persona
{
    protected string? Materia { get; set; }
    protected float Sueldo { get; set; }
    public Profesor() : base() { System.Console.WriteLine("Profesor creado..."); }
    public Profesor(string nombre, int edad, string materia, float sueldo) : base(nombre, edad)
    {
        Materia = materia;
        Sueldo = sueldo;
    }
}

public static class PersonaFactory
{
    public static Persona CreatePersona(string tipoPersona)
    {
        string tipo = tipoPersona.ToLower();
        if (tipo != "")
        {
            switch (tipo)
            {
                case "profesor":
                    return new Profesor();
                case "alumno":
                    return new Alumno();
                default:
                    System.Console.WriteLine($"El tipo de persona {tipo} no es correcto");
                    return null!;
            }
        }
        throw new NotImplementedException();
    }
}