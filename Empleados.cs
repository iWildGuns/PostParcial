namespace DOOProgram;
/*
Ejercicio 2 – Sistema de empleados
Implemente una aplicación para gestionar empleados de una empresa.
Cree una clase Empleado con Id, Nombre, Apellido y SueldoBase.
Genere las clases hijas EmpleadoPermanente y EmpleadoTemporal, que redefinan el método
CalcularSueldo() según su modalidad. Un ejemplo podría ser que el empleado permanente tiene un
extra de antigüedad.
*/
public abstract class Empleado
{
    protected static int Id { get; set; }
    protected string? Nombre { get; set; }
    protected string? Apellido { get; set; }
    protected float SueldoBase { get; set; }
    public Empleado() { System.Console.WriteLine("Se ha creado el empleado con exito"); }
    public Empleado(string nombre, string apellido, float sueldoBase)
    {
        Random rdm = new Random();
        Id = rdm.Next(1111, 9999);
        Nombre = nombre;
        Apellido = apellido;
        SueldoBase = sueldoBase;
    }
    public abstract void CalcularSueldo();
}
public class EmpleadoPermanente : Empleado
{
    protected int Antiguedad { get; set; }
    public EmpleadoPermanente() : base() { System.Console.WriteLine("Empleado permanente creado..."); }
    public EmpleadoPermanente(string nombre, string apellido, float sueldoBase, int antiguedad) : base(nombre, apellido, sueldoBase)
    {
        Antiguedad = antiguedad;
    }
    public override void CalcularSueldo()
    {
        float sueldo = SueldoBase * Antiguedad;
        System.Console.WriteLine($"el sueldo es de {sueldo}");
    }
}
public class EmpleadoTemporal : Empleado
{
    protected int CantidProyectosPersonales { get; set; }
    public EmpleadoTemporal() : base() { System.Console.WriteLine("Empleado temporal creado..."); }
    public EmpleadoTemporal(string nombre, string apellido, float sueldoBase, int cantidProyectosPersonales) : base(nombre, apellido, sueldoBase)
    {
        CantidProyectosPersonales = cantidProyectosPersonales;
    }
    public override void CalcularSueldo()
    {
        float sueldo = (CantidProyectosPersonales * 100) + SueldoBase;
        System.Console.WriteLine($"el sueldo es de {sueldo}");
    }
}
public static class EmpleadoFactory
{
    public static Empleado createEmpleado(string tipoEmpleado)
    {
        string tipo = tipoEmpleado.ToLower();
        if (tipo != "")
        {
            switch (tipo)
            {
                case "empleado permanente":
                    return new EmpleadoPermanente();
                case "empleado temporal":
                    return new EmpleadoTemporal();
                default:
                    System.Console.WriteLine($"El tipo de empleado {tipoEmpleado} no es correcto");
                    return null!;
            }
        }
        throw new NotImplementedException();
    }
}
