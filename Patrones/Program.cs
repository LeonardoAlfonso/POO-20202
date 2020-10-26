using System;
using Patrones.Decorator.Adicionales;
using Patrones.Decorator.TiposCarros;
using Patrones.Observer;
using Patrones.Singleton;
using Patrones.Strategy;
using Patrones.Strategy.Reflection;
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
            // try
            // {
            //     CasaCambioContext CasaCambio = new CasaCambioContext("asdfa");
            //     double resultado = CasaCambio.ConsultarCambio(100);
            //     Console.WriteLine(resultado);
            // }
            // catch(ArgumentNullException ex)
            // {
            //     Console.WriteLine("Ese tipo de cambio no existe");
            // }
            
            #endregion Strategy

            #region Decorator
            // Mazda mazda = new Mazda();
            // VentanasPolarizadas CarroConVentanasPolarizadas = new VentanasPolarizadas();
            // CamaraReversa CarroConCamaraReversa = new CamaraReversa();
            // CarroConVentanasPolarizadas.Carro = mazda;
            // CarroConCamaraReversa.Carro = CarroConVentanasPolarizadas;
            // VentanaElectrica CarroConVentanaE = new VentanaElectrica();
            // CarroConVentanaE.Carro = CarroConCamaraReversa;
            // Console.WriteLine(CarroConVentanaE.GetCosto());
            #endregion Decorator

            // PruebasReflection Pruebas = new PruebasReflection();
            // ICambioMoneda x = Pruebas.Test("PesoEuro");
            // var c = x.realizarCambio(100);

            #region Observer
            GestorAlarmas Gestor = new GestorAlarmas();
            AlarmaSonora alarma1 = new AlarmaSonora();
            AlarmaSonora alarma2 = new AlarmaSonora();
            AlarmaSonora alarma3 = new AlarmaSonora();
            LucesEmergencia alarma4 = new LucesEmergencia();
            Policia alarma5 = new Policia();
            Gestor.Suscribe(alarma1);
            Gestor.Suscribe(alarma3);
            Gestor.Suscribe(alarma5);
            Gestor.Notify("Se metió un ladrón");

            #endregion Observer

        }
    }
}
