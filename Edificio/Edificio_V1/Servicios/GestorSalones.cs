using System;
using System.Collections.Generic;
using System.Linq;
using Edificio_V1.EdificioEstructura;
using Edificio_V1.Procesos;

namespace Edificio_V1.Servicios
{
    public class GestorSalones
    {
        #region Properties
        private Edificio edificioSeleccionado;

        
        #endregion Properties

        #region Getters & Setters
        public Edificio EdificioSeleccionado
        {
            get { return edificioSeleccionado; }
            set { edificioSeleccionado = value; }
        }
        #endregion Getters & Setters

        #region Initialize
        public GestorSalones(Edificio e)
        {
            EdificioSeleccionado = e;
        }
        #endregion Initialize

        #region Methods
        public List<string> RetornarSalones()
        {
            return EdificioSeleccionado.Salones.Select(s => s.IdSalon).ToList();
        }
        public List<Reserva> MostrarDisponibilidad(string IdSalon)
        {
            List<Reserva> ReservasSalonSeleccionado = EdificioSeleccionado.Salones.First(s => s.IdSalon == IdSalon).Reservas;
            return ReservasSalonSeleccionado;
        }
        public void ReservarSalon(Reserva reserva)
        {
            Salon salonSeleccionado = EdificioSeleccionado.Salones.First(s=> 
                s.Reservas.Any(r => ((reserva.HoraFin <= r.HoraInicio || reserva.HoraInicio >= r.HoraFin) && reserva.Dia == r.Dia)));
            salonSeleccionado.Reservas.Add(reserva);
        }
        #endregion Methods
    }
}