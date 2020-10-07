using System;

namespace ExceptionsExamples.CustomExceptions
{
    public class NumeratorZeroException : Exception
    {
        public NumeratorZeroException() : base("Numerador Invalido") {}

        public NumeratorZeroException(string Message) : base(String.Format("El numerador actual no puede ser {0}", Message)) { }

        public NumeratorZeroException(string Message, Exception inner) : base(String.Format("El numerador actual no puede ser {0}", Message), inner) { }
    }
}