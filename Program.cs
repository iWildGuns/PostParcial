namespace DOOProgram;

class Program
{
    //* De tarea, Pasar la base de datos simulada a un Modelo */
    public static List<Vehiculo> ListVe = [];
    public static List<Producto> ListPro = [];

    static void Main()
    {
        //* Creamos un Vehiculo
        Vehiculo car1 = new Auto("Toyota", "Corolla", "2006", 4);
        System.Console.WriteLine(car1.GetId);

        //* Solo para llevar un control del Id de un vehiculo sin persistencia y poder trabajar con el en el programa, editamos su Id con una funcion falopa */
        car1.SetId(6543);

        //* Agregando el vehiculo a la lista */
        VehiculoController.AgregarVehiculo(car1);

        //* Iterando en la lista de Vehiculos para seleccionar un vehiculo por su Id */
        VehiculoController.SeleccionarVehiculoPorId(6543);
    }
}