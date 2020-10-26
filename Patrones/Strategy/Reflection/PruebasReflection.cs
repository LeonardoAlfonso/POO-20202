using System;

namespace Patrones.Strategy.Reflection
{
    public class PruebasReflection
    {
        public ICambioMoneda Test(string nombreClase)
        {
            string fullName = string.Concat("Patrones.Strategy.", nombreClase);
            Type classtype = Type.GetType(fullName);
            ICambioMoneda clase = (ICambioMoneda)Activator.CreateInstance(classtype);
            return clase;
        }
    }
}