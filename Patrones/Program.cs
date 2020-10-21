using System;
using Patrones.Decorator.Adicionales;
using Patrones.Decorator.TiposCarros;
using Patrones.Singleton;
using Patrones.Strategy;
using Patrones.TiposEmpleados;

namespace Patrones
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Builder
            // Director creadorEmpleados = new Director();
            // creadorEmpleados.Builder = new Desarrollador();
            // Empleado empleado = creadorEmpleados.ConstruirEmpleado("Jeremias", 20, "JereStar", "password123", "Avenidad Siempre Viva",
            //                                        "Barrio2", "Cali", "Bloque 9 Apto 203");
            // Console.WriteLine(empleado.Email.Dominio);
            #endregion Builder

            #region Singleton
            // BaseDatos DB = BaseDatos.Instancia;
            // DB.Port = "8000";
            // BaseDatos DB2 = BaseDatos.Instancia;
            // DB2.Username = "Pollo";
            // Console.WriteLine(DB2.Port);
            // Console.WriteLine(DB.Username);
            #endregion Singleton

            #region Singleton2
            // BaseDatos2 DB3 = BaseDatos2.GetData();
            // DB3.Port = "8000";
            // BaseDatos2 DB4 = BaseDatos2.GetData();
            // DB4.Username = "Pollo";
            // Console.WriteLine(DB4.Port);
            // Console.WriteLine(DB3.Username);
            #endregion Singleton2

            #region Strategy
            // CasaCambioContext CasaCambio = new CasaCambioContext("DolarPeso");
            // double resultado = CasaCambio.ConsultarCambio(100);
            // Console.WriteLine(resultado);
            #endregion Strategy

            #region Decorator
            Mazda mazda = new Mazda();
            VentanasPolarizadas CarroConVentanasPolarizadas = new VentanasPolarizadas();
            CamaraReversa CarroConCamaraReversa = new CamaraReversa();
            CarroConVentanasPolarizadas.Carro = mazda;
            CarroConCamaraReversa.Carro = CarroConVentanasPolarizadas;
            VentanaElectrica CarroConVentanaE = new VentanaElectrica();
            CarroConVentanaE.Carro = CarroConCamaraReversa;
            Console.WriteLine(CarroConVentanaE.GetCosto());
            #endregion Decorator

        }
    }
}
