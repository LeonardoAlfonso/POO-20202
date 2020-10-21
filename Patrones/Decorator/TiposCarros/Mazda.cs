namespace Patrones.Decorator.TiposCarros
{
    public class Mazda : Carro
    {
        public Mazda()
        {
            CostoInicial = 50000;
        }
        public override double GetCosto()
        {
            return CostoInicial;
        }
    }
}