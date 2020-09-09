using System;

namespace Contenedores.Objetos
{
    class Tupla
    {
        public void test()
        {
            // Tuple<int, string, Usuario> codigoUsuario = new Tuple<int, string, Usuario>((2, "Seguridad", new Usuario() {Nombre = "Pedro"});
            // Console.WriteLine(codigoUsuario.Item2);
            Tuple<int, long, string, bool, Usuario, int, bool, Usuario> test;

            Tuple<int, string, Usuario> codigo2 = Tuple.Create(2, "Seguridad", new Usuario() {Nombre = "Pedro"});
        }
    }
}