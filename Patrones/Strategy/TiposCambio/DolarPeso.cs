
namespace Patrones.Strategy
{
    public class DolarPeso : ICambioMoneda
    {
        public double realizarCambio(double valor)
        {
            double tranformacion = valor * 3800;
            return tranformacion;
        }
    }
}