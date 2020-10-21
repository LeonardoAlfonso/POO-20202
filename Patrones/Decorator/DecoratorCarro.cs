namespace Patrones.Decorator
{
    public class DecoratorCarro : Carro
    {
        public Carro Carro { get; set; }

        public override double GetCosto()
        {
            return CostoInicial + Carro.GetCosto();
        }
    }
}