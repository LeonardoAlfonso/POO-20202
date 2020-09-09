using System;
using System.Collections.Generic;

namespace Contenedores.Objetos
{
    class EjemplosDiccionarios
    {
        public void test()
        {
            Dictionary<int, string> usuarios = new Dictionary<int, string>();
            usuarios.Add(12, "Leonardo");
            usuarios.Add(45, "Maria");
            usuarios.Add(32, "Jose");

            // foreach( KeyValuePair<int, string> kvp in usuarios )
            // {
            //     Console.WriteLine("Key = {0}, Value = {1}",
            //         kvp.Key, kvp.Value);
            // }

            // string nombreEncontrado = "";
            // if(usuarios.TryGetValue(32, out nombreEncontrado))
            // {
            //     Console.WriteLine("El nombre encontrado es " + nombreEncontrado);
            // }
            // Console.WriteLine(usuarios.TryGetValue(13, out nombreEncontrado));.
            // usuarios.Add(32, "Liliana");
            usuarios[32] = "Liliana";

            foreach( KeyValuePair<int, string> kvp in usuarios )
            {
                Console.WriteLine("Key = {0}, Value = {1}",
                    kvp.Key, kvp.Value);
            }
        }
    }
}