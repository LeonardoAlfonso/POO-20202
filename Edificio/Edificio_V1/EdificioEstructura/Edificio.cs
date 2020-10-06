using System;
using System.Collections.Generic;
using System.Linq;
using Edificio_V1.Procesos;
using Edificio_V1.Usuarios;

namespace Edificio_V1.EdificioEstructura
{
    public class Edificio
    {
        #region Properties
        private List<Salon> salones;
        private Usuario usuario;
        #endregion Properties

        #region Getters & Setters
        public List<Salon> Salones
        {
            get { return salones; }
            set { salones = value; }
        }
        public Usuario Usario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        #endregion Getters & Setters

        #region Initialize
        public Edificio()
        {
            salones = new List<Salon>();
        }
        #endregion Initialize

        #region Methods
        public void ReservarSalon()
        {
            bool reservaConfirmada = false;
            Console.WriteLine("Cuál es el día para la reserva");
            string dia = Console.ReadLine();
            Console.WriteLine("Cuál es el hora inicio para la reserva");
            string horaInicio = Console.ReadLine();
            Console.WriteLine("Cuál es el hora final para la reserva");
            string horafinal = Console.ReadLine();
            Reserva reserva = new Reserva()
            {
                Dia = Convert.ToInt32(dia),
                HoraInicio = Convert.ToInt32(horaInicio),
                HoraFin = Convert.ToInt32(horafinal),
            };
            Salones.ForEach(s=> {
                if (!reservaConfirmada)
                {
                    s.Reservas.ForEach(r => {
                        if ((reserva.HoraFin <= r.HoraInicio || reserva.HoraInicio >= reserva.HoraFin) 
                            && reserva.  Dia == r.Dia && !reservaConfirmada) {
                            s.Reservas.Add(reserva);
                            reservaConfirmada = true;
                        }
                    });
                }
            });
        }
        #endregion Methods
    }
}