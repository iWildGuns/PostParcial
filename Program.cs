using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace DOOProgram;
/*
haceme un CRUD similar a API rest en estructura MVC de vehículos autos y motos en C# para la materia de Desarrollo Orientado a Objetos con datos estáticos sin menú
*/

/**
Se desea además que para cada ejercicio se logre realizar una colección (lista) de objetos creados
por su clase padre y a su vez, mostrar todos los elementos disponibles en la lista.
Defina dentro del main métodos para:
Agregar un nuevo elemento (de cualquier tipo).
Modificar los datos de un elemento existente.
Eliminar un elemento por su Id.
*/
class Program
{
    //     public static class Factory
    //     {
    //         public static Object createElement(string tipoElemento)
    //         {
    //             string tipo = tipoElemento.ToLower();
    //             if (tipo != "")
    //             {
    //                 switch (tipo)
    //                 {
    //                     case "cuenta corriente":
    //                         return new CuentaCorriente();
    //                     case "caja de ahorro":
    //                         return new CajaAhorro();
    //                     case "empleado permanente":
    //                         return new EmpleadoPermanente();
    //                     case "empleado temporal":
    //                         return new EmpleadoTemporal();
    //                     case "profesor":
    //                         return new Profesor();
    //                     case "alumno":
    //                         return new Alumno();
    //                     case "producto alimenticio":
    //                         return new ProductoAlimenticio();
    //                     case "producto electronico":
    //                         return new ProductoElectronico();
    //                     case "auto":
    //                         return new Auto();
    //                     case "moto":
    //                         return new Moto();
    //                     case "camion":
    //                         return new Camion();
    //                     default:
    //                         System.Console.WriteLine("El tipo de elemento no es correcto");
    //                         return null!;
    //                 }
    //             }
    //             throw new NotImplementedException();
    //         }
    //     }

    public static void Main()
    {

        //* METODO QUE CREA EL ELEMENTO DENTRO DEL MAIN 🤷 */

        Object createElement(string tipoElemento)
        {
            string tipo = tipoElemento.ToLower();
            if (tipo != "")
            {
                switch (tipo)
                {
                    case "cuenta corriente":
                        return new CuentaCorriente();
                    case "caja de ahorro":
                        return new CajaAhorro();
                    case "empleado permanente":
                        return new EmpleadoPermanente();
                    case "empleado temporal":
                        return new EmpleadoTemporal();
                    case "profesor":
                        return new Profesor();
                    case "alumno":
                        return new Alumno();
                    case "producto alimenticio":
                        return new ProductoAlimenticio();
                    case "producto electronico":
                        return new ProductoElectronico();
                    case "auto":
                        return new Auto();
                    case "moto":
                        return new Moto();
                    case "camion":
                        return new Camion();
                    default:
                        System.Console.WriteLine("El tipo de elemento no es correcto");
                        return null!;
                }
            }
            throw new NotImplementedException();
        }

        // VehiculoFactory.crearVehiculo("auto");
        // ProductoFactory.crearProducto("Producto Alimenticio");
        // PersonaFactory.CreatePersona("ALUMNO");
        // EmpleadoFactory.createEmpleado("empleadO permanenTE");
        // CuentaFactory.createCuenta("cuenta corriente");
        createElement("profesor");

        createElement("auto");

        Auto a1 = new();

        List<Vehiculo> ListaVehiculos = [];

































        a1.Reproducir();

        // Listado de elementos 

        // List<Vehiculo> lV = [
        //     new Auto("Toyota", "Corolla", 2006, 4),
        //     new Auto("Jeep", "GranCheroke", 2016, 4),
        //     new Moto("Honda", "CB300", 2020, 300),
        //     new Moto("Yamaha", "XTZ", 2014, 125),
        //     new Camion("Mercedes-Benz", "Ageto", 2025, 45000),
        //     new Camion("Foton", "Auman", 2020, 17000)
        // ];
        // List<Producto> lP = [
        //     new ProductoAlimenticio("Coca-Cola", 3200),
        //     new ProductoAlimenticio("Mayonesa", 1500),
        //     new ProductoElectronico("Heladera", 60000, "Electrolux", "h233l2"),
        //     new ProductoElectronico("SmartTv", 200000, "Samsung", "Lv123ds")
        // ];
        // List<Persona> lPer = [
        //     new Alumno("Hector", 30, "A23D", 9),
        //     new Alumno("Stevan", 18, "B23D", 10),
        //     new Profesor("Laurato", 68, "DOO", 3000000),
        //     new Profesor("Celeste", 32, "Matematicas", 700000)
        // ];
        // List<Cuenta> lC = [
        //     new CuentaCorriente("Michael", 800000, 1000000),
        //     new CuentaCorriente("Gonzalo", 500000, 1500000),
        //     new CajaAhorro("Jimena", 300000, 15),
        //     new CajaAhorro("Monica", 700000, 18),
        // ];
        // foreach (Vehiculo item in lV) System.Console.WriteLine();
        // foreach (Producto item in lP) System.Console.WriteLine();
        // foreach (Persona item in lPer) System.Console.WriteLine();
        // foreach (Cuenta item in lC) System.Console.WriteLine();
    }

}
