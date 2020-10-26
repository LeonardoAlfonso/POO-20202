using System;

namespace Patrones.Observer
{
    public class Policia : IObserverAlarma
    {
        public void update(string problemaSeguridad)
        {
            Console.WriteLine("Se llama a lo policia por el problema " + problemaSeguridad);
        }
    }
}