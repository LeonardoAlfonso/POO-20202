using System;
using System.Collections.Generic;
using System.Linq;
using Edificio_V1.Procesos;

namespace Edificio_V1.EdificioEstructura
{
    public class Salon
    {
        #region Properties        
        private string idSalon;        
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
        public string IdSalon
        {
            get { return idSalon; }
            set { idSalon = value; }
        }
        #endregion Getters & Setters

        #region Initialize
        public Salon()
        {
            Random random = new Random();
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            string result = new string(Enumerable.Repeat(chars, 6)
                                      .Select(s => s[random.Next(s.Length)])
                                      .ToArray());
            IdSalon = result;
        }
        #endregion Initialize

        #region Methods
        #endregion Methods
    }
}