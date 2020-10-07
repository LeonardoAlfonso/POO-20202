using System.Collections.Generic;
using System.Linq;
using Excepciones.CustomExceptions;

namespace linq.Torneo
{
    public class Equipo
    {
        #region Properties  
        public int Goles { get; set; }
        public int Asistencias { get; set; }
        public int Faltas { get; set; }
        public int TarjetasAmarillas { get; set; }
        public int TarjetasRojas { get; set; }
        public Seleccion Seleccion { get; set; }
        public bool EsLocal { get; set; }

        #endregion Properties

        #region Initialize
        public Equipo(Seleccion seleccion)
        {
            this.Seleccion = seleccion;
        }
        #endregion Initialize

        #region Methods
        public void ExpulsarJugador(string name)
        {
            if (Seleccion.Jugadores.Count < 8)
                throw new LoseForWException(Seleccion.Nombre);
            Jugador jugadorExpulsado = Seleccion.Jugadores.First(j => j.Nombre == name);
            Seleccion.Jugadores.Remove(jugadorExpulsado);
        }
        #endregion Methods
    }
}