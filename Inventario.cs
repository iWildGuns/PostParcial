namespace DOOProgram;
/*
Ejercicio 3 – Inventario de productos
Se desea desarrollar un sistema para gestionar el inventario de una tienda.
Cree una clase padre Producto con los atributos Id, Nombre y PrecioBase.
A partir de ella, crear las clases hijas ProductoAlimenticio (con FechaVencimiento) y
ProductoElectronico (con MesesGarantia).
Extra:
Listar todo el inventario mostrando el tipo de producto.
*/
public abstract class Producto
{
    protected int Id { get; set; }
    protected string? Nombre { get; set; }
    protected float PrecioBase { get; set; }
    public Producto() { System.Console.WriteLine("Se ha creado el producto con exito"); }
    public Producto(string nombre, float precioBase)
    {
        Random rdm = new Random();
        Id = rdm.Next(1111, 9999);
        Nombre = nombre;
        PrecioBase = precioBase;
    }
    public int getId { get { return Id; } }
}
public class ProductoAlimenticio : Producto
{
    protected DateOnly FechaVencimiento { get; set; } = DateOnly.FromDateTime(DateTime.Now).AddYears(1);
    public ProductoAlimenticio() : base() { System.Console.WriteLine("Producto alimenticio creado..."); }
    public ProductoAlimenticio(string nombre, float precioBase) : base(nombre, precioBase) { }
    public DateOnly getFechaVencimiento { get { return FechaVencimiento; } }
}
public class ProductoElectronico : Producto
{
    protected string? Marca { get; set; }
    protected string? Modelo { get; set; }
    public ProductoElectronico() : base() { System.Console.WriteLine("Producto electronico creado..."); }

    public ProductoElectronico(string nombre, float precioBase, string marca, string modelo) : base(nombre, precioBase)
    {
        Marca = marca;
        Modelo = modelo;
    }
}

public static class ProductoFactory
{
    public static Producto crearProducto(string tipoProducto)
    {
        string tipo = tipoProducto.ToLower();
        if (tipo != "")
        {
            switch (tipo)
            {
                case "producto alimenticio":
                    return new ProductoAlimenticio();
                case "producto electronico":
                    return new ProductoElectronico();
                default:
                    System.Console.WriteLine($"El tipo de producto {tipo} no es correcto");
                    return null!;
            }
        }
        throw new NotImplementedException();
    }
}