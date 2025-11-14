namespace DOOProgram;

/**
Ejercicio 5 – Sistema bancario
Cree una aplicación para administrar cuentas bancarias.
Defina la clase Cuenta con NumeroCuenta, Titular y Saldo.
Clases hijas: CajaAhorro (con tasa de interés) y CuentaCorriente (con límite de descubierto).
*/

public abstract class Cuenta
{
    protected string? NumCuenta { get; set; }
    protected string? Titular { get; set; }
    protected float Saldo { get; set; }
    public Cuenta() : base() { System.Console.WriteLine("Se ha creado la cuenta con exito"); }
    public Cuenta(string titular, float saldo)
    {
        Random rnd = new();
        NumCuenta = rnd.Next(1111, 9999).ToString();
        Titular = titular;
        Saldo = saldo;
    }
}
public class CajaAhorro : Cuenta
{
    protected float TasaInteres { get; set; }
    public CajaAhorro() : base() { System.Console.WriteLine("Caja de ahorro creada..."); }
    public CajaAhorro(string titular, float saldo, float tasaInteres) : base(titular, saldo)
    {
        TasaInteres = tasaInteres;
    }
}
public class CuentaCorriente : Cuenta
{
    protected float LimiteDeDescubierto { get; set; }
    public CuentaCorriente() : base() { System.Console.WriteLine("Cuenta corriente creada..."); }
    public CuentaCorriente(string titular, float saldo, float limiteDeDescubierto) : base(titular, saldo)
    {
        LimiteDeDescubierto = limiteDeDescubierto;
    }
}

public static class CuentaFactory
{
    public static Cuenta createCuenta(string tipoCuenta)
    {
        string tipo = tipoCuenta.ToLower();
        if (tipo != "")
        {
            switch (tipo)
            {
                case "cuenta corriente":
                    return new CuentaCorriente();
                case "caja de ahorro":
                    return new CajaAhorro();
                default:
                    System.Console.WriteLine($"El tipo de cuenta {tipoCuenta} no es correcta");
                    return null!;
            }
        }
        throw new NotImplementedException();
    }
}