using System;
using Banco.Usuarios;
using Banco.Cuentas;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cliente clienteMiguel = new Cliente()
            // {
            //     Nombre = "Miguel",
            //     Documento = "1016586925",
            //     Password = 1234,
            //     Celular = "3156548974"
            // };
            
            // CuentaAhorros cuenta1 = new CuentaAhorros();
            // cuenta1.Clave = 1234;
            // cuenta1.Tope = 500000;
            // cuenta1.IngresarSaldo(50000);
            // clienteMiguel.CuentaPrincipal = cuenta1;

            // Console.WriteLine(clienteMiguel.CuentaPrincipal.Saldo);

            DateTime now = DateTime.Now;
            string nowS = now.ToString("dd/MM/yyyy hh:mm tt");
            Console.WriteLine(nowS);
            
        }
    }
}
