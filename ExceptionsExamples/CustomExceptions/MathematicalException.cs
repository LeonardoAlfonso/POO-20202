using System;

namespace ExceptionsExamples.CustomExceptions
{
    public class MathematicalException : Exception
    {
        public MathematicalException() : base("Error Matemático") {}

        public MathematicalException(string Message) : base(Message) { }

        public MathematicalException(string Message, Exception inner) : base(Message, inner) { }
    }
}