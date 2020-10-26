
using System;

namespace Patrones.Strategy
{
    public class CasaCambioContext 
    {
        private ICambioMoneda strategy;
        public ICambioMoneda Strategy
        {
            get { return strategy; }
            set { strategy = value; }
        }
        public CasaCambioContext(string tipo)
        {
            string fullName = string.Concat("Patrones.Strategy.TiposCambio.", tipo);
            Type classtype = Type.GetType(fullName);
            ICambioMoneda clase = (ICambioMoneda)Activator.CreateInstance(classtype);
            Strategy = clase;
        }
        public double ConsultarCambio(double dinero)
        {
            return Strategy.realizarCambio(dinero);
        }
        
    }
}