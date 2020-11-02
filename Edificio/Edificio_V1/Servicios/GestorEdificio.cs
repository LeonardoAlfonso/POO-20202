using System;
using System.Collections.Generic;
using System.Linq;
using Edificio_V1.EdificioEstructura;
using Edificio_V1.Procesos;

namespace Edificio_V1.Servicios
{
    public class GestorEdificio
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
        public GestorEdificio(Edificio e)
        {
            EdificioSeleccionado = e;
        }
        #endregion Initialize

        #region Methods
        public Salon RetornarEstadoSalon(string idSalon, string hora, string minutos)
        {
            int horaSeleccionada = Convert.ToInt32(hora);
            int minutosSeleccionados = Convert.ToInt32(minutos);
            Salon salonSeleccionado = EdificioSeleccionado.Salones.First(s => s.IdSalon == idSalon);
            bool salonOcupado = salonSeleccionado.Reservas.Any(r => 
                                            (horaSeleccionada >= r.HoraInicio && horaSeleccionada <= r.HoraFin) || 
                                            (r.HoraInicio - minutosPorcentaje(EdificioSeleccionado.HoraLuz)
                                            <= r.HoraInicio - minutosPorcentaje(minutosSeleccionados))
            );
            if (salonOcupado)
            {
                salonSeleccionado.Luz = true;
                salonSeleccionado.Temperatura = EdificioSeleccionado.Temperatura;
            }
            else
            {
                salonSeleccionado.Luz = false;
                salonSeleccionado.Temperatura = new Random().Next(25,35);
            }
            return salonSeleccionado;
        }

        private double minutosPorcentaje(int minutos)
        {
            double factorEdificio = (minutos) / 60;
            return factorEdificio;
        }
        #endregion Methods
    }
}