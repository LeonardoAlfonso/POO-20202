using System;

namespace Patrones.Observer
{
    public class AlarmaSonora : IObserverAlarma
    {
        public void update(string problemaSeguridad)
        {
            Console.WriteLine("Suena la alarma por el problema " + problemaSeguridad);
        }
    }
}