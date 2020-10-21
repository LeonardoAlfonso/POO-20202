namespace Patrones.Decorator
{
    public abstract class Carro
    {
        protected double CostoInicial { get; set; }

        public abstract double GetCosto();
    }
}