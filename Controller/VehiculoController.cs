using System.Security.Cryptography.X509Certificates;

namespace DOOProgram;

public class VehiculoController()
{
    public static void AgregarVehiculo(Vehiculo v)
    {
        Program.ListVe.Add(v);
        System.Console.WriteLine($"Agregado");
    }
    public static void SeleccionarVehiculoPorId(int id)
    {
        foreach (Vehiculo item in Program.ListVe)
        {
            if (item.GetId == id)
            {
                System.Console.WriteLine($"Vehiculo {item.GetMarca}, Modelo {item.GetModelo} del año {item.GetAnio}");
                return;
            }
        }
        System.Console.WriteLine("Vehiculo no encontrado");
        return;
    }
    public static void EditarVehiculo(Vehiculo v, string marca, string modelo, string anio)
    {
        v.SetMarca(marca);
        v.SetModelo(modelo);
        v.SetAnio(anio);
        Console.WriteLine("Vehiculo Modificado Correctamente...");
        return;
    }
    public static void EliminarVehiculo(Vehiculo v)
    {
        Program.ListVe.Remove(v);
        System.Console.WriteLine($"Vehiculo");
    }
    public static void MostrarListado()
    {
        foreach (Vehiculo item in Program.ListVe)
        {
            System.Console.WriteLine($"{item.GetMarca}");
        }
    }
}