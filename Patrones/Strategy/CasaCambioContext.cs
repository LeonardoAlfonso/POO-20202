
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
            if (tipo == "DolarPeso")
            {
                Strategy = new DolarPeso();
            }
            else if (tipo == "YenPeso")
            {
                Strategy = new YenPeso();
            }
            else
            {
                Strategy = new PesoEuro();
            }
        }
        public double ConsultarCambio(double dinero)
        {
            return Strategy.realizarCambio(dinero);
        }
        
    }
}