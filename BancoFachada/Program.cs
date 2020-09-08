using System;
using BancoFachada.Tramites;

namespace BancoFachada
{
    class Program
    {
        static void Main(string[] args)
        {
            FachadaCtaAhorros fachadaBanco = new FachadaCtaAhorros();
            fachadaBanco.SaludarCliente();
        }
    }
}
