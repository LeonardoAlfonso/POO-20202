namespace Patrones.Decorator.TiposCarros
{
    public class Audi : Carro
    {
        public Audi()
        {
            CostoInicial = 50000;
        }
        public override double GetCosto()
        {
            return CostoInicial;
        }
    }
}