namespace DOOProgram;

/*
Ejercicio 1 – Gestión de vehículos
Diseñe un sistema para administrar los vehículos que ingresan a un taller.
Cree una clase padre Vehiculo con los atributos: Id, Marca, Modelo y Año.
A partir de ella, crear las clases Auto, Moto y Camion, que agreguen atributos específicos (por
ejemplo, cantidadPuertas, cilindrada, capacidadCarga).
*/
public abstract class Vehiculo : IReproducirMusica
{
    protected int Id { get; set; }
    protected string? Marca { get; set; }
    protected string? Modelo { get; set; }
    protected int Anio { get; set; }
    public Vehiculo() { System.Console.WriteLine("Se ha creado el vehiculo con exito"); }
    public Vehiculo(string marca, string modelo, int anio)
    {
        Random rdm = new Random();
        Id = rdm.Next(1111, 9999);
        Marca = marca;
        Modelo = modelo;
        Anio = anio;
    }
    public abstract void Reproducir();
    public string getId { get { return Id.ToString(); } }
}

public class Auto : Vehiculo
{
    protected int CanitdadDePuertas { get; set; }
    public Auto() : base() { System.Console.WriteLine("Auto creado..."); }
    public Auto(string marca, string modelo, int anio, int cantidadDePuertas) : base(marca, modelo, anio) { CanitdadDePuertas = cantidadDePuertas; }

    public override void Reproducir()
    {
        System.Console.WriteLine($"*Suena rapido y furiosos de fondo*");
    }
}
public class Moto : Vehiculo
{
    protected int Cilindrada { get; set; }
    public Moto() : base() { System.Console.WriteLine("Moto creada..."); }
    public Moto(string marca, string modelo, int anio, int cilindrada) : base(marca, modelo, anio) { Cilindrada = cilindrada; }
    public override void Reproducir()
    {
        System.Console.WriteLine($"*Suenan los aldeanos*");
    }
}
public class Camion : Vehiculo
{
    protected float CapacidadDeCarga { get; set; }
    public Camion() : base() { System.Console.WriteLine("Camion creado..."); }
    public Camion(string marca, string modelo, int anio, float capacidadDeCarga) : base(marca, modelo, anio) { CapacidadDeCarga = capacidadDeCarga; }
    public override void Reproducir()
    {
        System.Console.WriteLine($"Suena cualquier cosa");
    }
}

public static class VehiculoFactory
{
    public static Vehiculo crearVehiculo(string tipoVehiculo)
    {
        string tipo = tipoVehiculo.ToLower();
        if (tipo != "")
        {
            switch (tipo)
            {
                case "auto":
                    return new Auto();
                case "moto":
                    return new Moto();
                case "camion":
                    return new Camion();
                default:
                    System.Console.WriteLine($"El tipo de vehiculo {tipo} no es correcto");
                    return null!;
            }
        }
        throw new NotImplementedException();
    }
}