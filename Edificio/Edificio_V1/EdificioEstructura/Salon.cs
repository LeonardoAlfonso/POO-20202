using System.Collections.Generic;
using Edificio_V1.Procesos;

namespace Edificio_V1.EdificioEstructura
{
    public class Salon
    {
        #region Properties
        private bool luz;
        private double temperatura;
        private List<Reserva> reservas;
        
        #endregion Properties

        #region Getters & Setters
        public bool Luz
        {
            get { return luz; }
            set { luz = value; }
        }
        public double Temperatura
        {
            get { return temperatura; }
            set { temperatura = value; }
        }
        public List<Reserva> Reservas
        {
            get { return reservas; }
            set { reservas = value; }
        }
        #endregion Getters & Setters

        #region Initialize
        #endregion Initialize

        #region Methods
        #endregion Methods
    }
}