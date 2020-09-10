using System;
using System.Collections;
using System.Collections.Generic;
using BancoValidator.Rules;
using BancoValidator.Validator;

namespace BancoValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            ValidateObject Nombre = new ValidateObject()
            {
                Value = "Ped"
            };
            ValidateObject Edad = new ValidateObject()
            {
                Value = 35
            };


            Nombre.Rules.Add(new StringRule());
            Nombre.Rules.Add(new LengthRule());
            Edad.Rules.Add(new IntRule());

            if (Nombre.ValidateField())
            {
                Console.WriteLine("Campo Correcto");
            }
            else
            {
                Console.WriteLine("Campo Fallido");
            }
            
        }
    }
}
