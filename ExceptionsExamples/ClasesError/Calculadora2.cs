using System;
using ExceptionsExamples.CustomExceptions;

namespace ExceptionsExamples.ClasesError
{
    public class Calculadora2
    {
        public double Division(int numero1, int numero2)
        {
            double response = 0;
            try
            {
                if (numero1 == 0)
                    throw new NumeratorZeroException(); //Error de lógica de negocio
                response = numero1 / numero2;  //Error matemático
            }
            catch (Exception ex)
            {
                throw new MathematicalException("",ex);
            }
            return response; 
        }
    }
}