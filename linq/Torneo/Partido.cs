using System;
using Excepciones.CustomExceptions;

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
            this.EquipoLocal = new Equipo(EquipoLocal);
            this.EquipoVisitante = new Equipo(EquipoVisitante);
        }

        public string Resultado()
        {
            string resultado = "0-0";
            try
            {
                EquipoLocal.ExpulsarJugador("Mbappe");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("No existe ese jugador para expulsarlo");
            }
            catch(LoseForWException ex)
            {
                Console.WriteLine(ex.Message);
                resultado = "0-3";
            }
            
            return resultado;

        }
        #endregion Initialize

    }
}