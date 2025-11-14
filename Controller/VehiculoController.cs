namespace DOOProgram;

public static class VehiculoController()
{
    public static void AgregarVehiculo(Vehiculo v)
    {
        Program.ListVe.Add(v);
        System.Console.WriteLine($"Agregado");
    }
    public static Vehiculo seleccionarVehiculo(Vehiculo v)
    {

        void editarVehiculo(string marca, string modelo, int anio)
        {
            v.SetMarca(marca);
            v.SetModelo(modelo);
            v.SetAnio(anio);
        }
        System.Console.WriteLine("Vehiculo Modificado Correctamente...");
        return v;
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