using System;

namespace Patrones.Observer
{
    public class LucesEmergencia : IObserverAlarma
    {
        public void update(string problemaSeguridad)
        {
            Console.WriteLine("Las luces de emergencia se encienden por el problema " + problemaSeguridad);
        }
    }
}