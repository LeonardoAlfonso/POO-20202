using System;
using System.Collections.Generic;
using System.Linq;
using linq.Torneo;

namespace linq
{
    class Program
    {
        static void Main(string[] args)
        {
            RepositorioDatos Datos = new RepositorioDatos();
            List<Seleccion> Selecciones = Datos.Selecciones;
            // List<String> Nombres = new List<string>();

            // foreach (Seleccion seleccion in Selecciones)
            // {
            //     if (seleccion.Nombre == "Francia")
            //     {
            //         foreach(Jugador jugador in seleccion.Jugadores)
            //         {
            //             Nombres.Add(jugador.Nombre);
            //         }
            //     }
            // }

            // Seleccion s = Selecciones.Where(s => s.Nombre == "Francia").ToList<Seleccion>()[0];
            Seleccion francia = Selecciones.First(s => s.Nombre == "Francia") as Seleccion;
            // List<String> nombres2 = francia.Jugadores.Select(jugador => jugador.Nombre).ToList();

            // List<String> nombres3 = Selecciones.First(s => s.Nombre == "Francia")
            //                                    .Jugadores.Select(jugador => jugador.Nombre).ToList();

            // Jugador últimoJugador = francia.Jugadores.First(j => j.Posicion == 11);

            // Jugador jugador33 = francia.Jugadores.FirstOrDefault(j => j.Edad == 33);
            // Jugador jugador332 = francia.Jugadores.LastOrDefault(j => j.Edad == 33);

            Seleccion Colombia = Selecciones.FirstOrDefault(s => s.Nombre == "Colombia") as Seleccion;
            // List<Jugador> JugadoresViejos = Colombia.Jugadores.Where(j => (j.Edad >= 26 && j.Edad <= 34)).ToList<Jugador>();

            // List<Jugador> JugadoresViejos2 = Colombia.Jugadores.Where(j => j.Edad >= 26)
            //                                                    .Where(j => j.Edad <= 33).ToList<Jugador>();

            // Seleccion Argentina = Selecciones.FirstOrDefault(s => s.Nombre == "Argentina") as Seleccion;
            // bool HayJugadorPro = Argentina.Jugadores.Any(j => j.Goles > 30);

            // List<Jugador> EspañaOrdenados = Selecciones.FirstOrDefault(s => s.Nombre == "España") 
            //                                            .Jugadores.OrderBy(j => j.Edad).ToList<Jugador>();

            // List<Jugador> EspañaOrdenados2 = Selecciones.FirstOrDefault(s => s.Nombre == "España") 
            //                                            .Jugadores.OrderByDescending(j => j.Edad).ToList<Jugador>();    

            var jugadorMax = francia.Jugadores.Max(j => j.Goles);
            var jugadorMin = francia.Jugadores.Min(j => j.Goles);

            List<Jugador> jugadoresCombinados = francia.Jugadores.Concat(Colombia.Jugadores).OrderBy(j => j.Ataque).ToList<Jugador>();
            int CantidadJugadores = jugadoresCombinados.Count;

        }
    }
}
