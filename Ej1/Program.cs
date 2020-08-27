using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace Ej1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> example1 = new List<double>()
            {
                3,4,5,6,7
            };
            example1.ForEach(z => Console.WriteLine(z));


            Lapiz lapiz1 = new Lapiz()
            {
                LongitudCuerpo = 10,
                LongitudPunta = 0.8
            };
            Lapiz lapiz2 = new Lapiz();
            lapiz2.LongitudPunta = 1;
            lapiz2.LongitudCuerpo = 20;

            Console.WriteLine("Digite el número de vueltas");     
            int vueltas = Convert.ToInt32(Console.ReadLine());

            lapiz1.SacarPunta(vueltas);
            ImprimirResultados(lapiz1);
            lapiz2.SacarPunta(vueltas);
            ImprimirResultados(lapiz2);

            void ImprimirResultados(Lapiz lapiz)
            {
                Console.WriteLine("Punta: " + lapiz.LongitudPunta);
                Console.WriteLine("Cuerpo: " + lapiz.LongitudCuerpo);
            }

            string json = JsonConvert.SerializeObject(lapiz2, Formatting.Indented);
            Console.WriteLine(json);
        }
    }
}
