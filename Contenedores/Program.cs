using System;
using System.Collections;
using System.Collections.Generic;
using Contenedores.Objetos;

namespace Contenedores
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue cola1 = new Queue();
            cola1.Enqueue("Maria");
            cola1.Enqueue("Carlos");
            cola1.Enqueue(25.2);
            cola1.Enqueue(new Usuario() {Nombre = "Maria"});

            Stack pila1 = new Stack();
            pila1.Push("Maria");
            pila1.Push("Carlos");
            pila1.Push(25.2);

            foreach( object o in pila1 )
            {
                //object -> Console.WriteLine (o.ToString());   -->   new Usuario().ToString => namespace+.Clase
                Console.WriteLine(o);
            }
        }
    }
}

