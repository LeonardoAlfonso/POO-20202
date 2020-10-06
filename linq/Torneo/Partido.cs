namespace linq.Torneo
{
    public class Partido
    {
        #region Properties  
        public Equipo EquipoLocal { get; set; }
        public Equipo EquipoVisitante { get; set; }

        #endregion Properties

        #region Initialize
        public Partido(Seleccion EquipoLocal, Seleccion EquipoVisitante) 
        {
            this.EquipoLocal.Seleccion = EquipoLocal;
            this.EquipoVisitante.Seleccion = EquipoVisitante;
        }
        #endregion Initialize

    }
}