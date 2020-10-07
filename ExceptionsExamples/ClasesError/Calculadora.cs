using System;
using ExceptionsExamples.CustomExceptions;

namespace ExceptionsExamples.ClasesError
{
    public class Calculadora
    {
        public double Division(int numero1, int numero2)
        {
            double response = 0;
            if (numero1 == 0)
                throw new NumeratorZeroException();
            response = numero1 / numero2;
            return response;
        }
    }
}