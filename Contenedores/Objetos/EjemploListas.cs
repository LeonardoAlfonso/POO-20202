using System;
using System.Collections.Generic;

namespace Contenedores.Objetos
{
    class Listas
    {
        public void test()
        {
                        List<string> listaNombres = new List<string>();
            listaNombres.Add("Carlos");
            listaNombres.Add("Maria");

            // Console.WriteLine(listaNombres.Count);

            // foreach( string i in listaNombres)
            // {
            //     Console.WriteLine(i);
            // }

            // Console.WriteLine(listaNombres[1]);

            // Console.WriteLine(listaNombres.Contains("Pedro"));
            // Console.WriteLine(listaNombres.Contains("Carlos"));
            Usuario l = new Usuario() { Nombre = "Leonardo" };

            List<Usuario> listaUsuarios = new List<Usuario>()
            {
                l,
                new Usuario() { Nombre = "Rosa"},           
            };

            listaUsuarios.ForEach(p => {
                string nombreMayus = p.Nombre.ToUpper();
                p.Edad = 35;
                // Console.WriteLine(nombreMayus + " " + p.Edad);
            });

            // Console.WriteLine(listaUsuarios[1].Edad);
            // Usuario usuarioSinEdad = new Usuario();
            // Console.WriteLine(usuarioSinEdad.Edad);
            listaUsuarios.Remove(l);
            Console.WriteLine(listaUsuarios.Count);
        }
    }
}