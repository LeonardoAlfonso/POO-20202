using System.Collections.Generic;

namespace linq.Torneo
{
    public class Seleccion
    {
        #region Properties  
        public string Nombre { get; set; }
        public int PuntosTotales { get; set; }
        public int GolesTotales { get; set; }
        public int AsistenciasTotales { get; set; }
        public List<Jugador> Jugadores { get; set; }

        #endregion Properties

        #region Initialize

        #endregion Initialize

    }
}