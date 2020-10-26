
namespace Patrones.Strategy.TiposCambio
{
    public class YenPeso : ICambioMoneda
    {
        public double realizarCambio(double valor)
        {
            double tranformacion = valor * 5000;
            return tranformacion;
        }
    }
}