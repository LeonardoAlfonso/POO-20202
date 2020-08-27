using System;
using Ejemplo2.Banco.Cuentas;

namespace Ejemplo2
{
    class Program
    {
        static void Main(string[] args)
        {
            CuentaAhorros cuenta1 = new CuentaAhorros();
            cuenta1.Referencia = "abc123";
            cuenta1.Saldo = 500000;
            cuenta1.Clave = 1234;
            // Console.WriteLine(cuenta1.Clave);

            double saldo = cuenta1.GetSaldo(1234, "aBc123");
        }
    }
}
