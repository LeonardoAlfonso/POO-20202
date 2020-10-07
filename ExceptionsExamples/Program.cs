using System;
using ExceptionsExamples.ClasesError;
using ExceptionsExamples.CustomExceptions;

namespace ExceptionsExamples
{
    class Program
    {
        static void Main(string[] args)
        {

            Calculadora2 calculadora = new Calculadora2();
            int code = 0;
            try
            {
                double res = calculadora.Division(1,0);
                Console.WriteLine(res.ToString());
                code = 200;
            }
            // catch(DivideByZeroException ex)
            // {
            //     Console.WriteLine(ex.Message);
            // }
            // catch(NumeratorZeroException ex)
            // {
            //     Console.WriteLine(ex.Message);
            // }
            catch (MathematicalException ex)
            {
                Console.WriteLine(ex.InnerException.Message);
                code = 409;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                code = 400;
            }
            finally
            {
                Console.WriteLine(code.ToString());
                //return code
            }
        }
    }
}
