using System;
using System.Collections.Generic;
using System.Linq;
using Edificio_V1.EdificioEstructura;
using Edificio_V1.Procesos;
using Edificio_V1.Servicios;

namespace Edificio_V1.UserInterface
{
    public class FachadaEdificios
    {
        #region Properties
        private Edificio edificio;
        private GestorSalones servicioSalones;
        
        #endregion Properties

        #region Getters & Setters
        public Edificio Edificio
        {
            get { return edificio; }
            set { edificio = value; }
        }
        public GestorSalones ServicioSalones
        {
            get { return servicioSalones; }
            set { servicioSalones = value; }
        }
        #endregion Getters & Setters

        #region Initialize
        public FachadaEdificios()
        {
            Edificio ed = new Edificio();
            servicioSalones = new GestorSalones(ed);
        }
        #endregion Initialize

        #region Methods
        public void MostrarDisponibilidad()
        {
            try
            {
                ServicioSalones.RetornarSalones().ForEach(s => Console.WriteLine(s));
                Console.WriteLine("Elija su salón:");
                string salonElegido = Console.ReadLine();
                ServicioSalones.MostrarDisponibilidad(salonElegido).ForEach(r => {
                    Console.WriteLine($"Dia Reserva: {r.Dia}");
                    Console.WriteLine($"Hora Inicio: {r.HoraInicio}");
                    Console.WriteLine($"Hora Inicio: {r.HoraFin}");
                });
            }
            catch(InvalidOperationException ex)
            {
                Console.WriteLine("Este salón no existe");
            }  
        }

        public void ReservarSalon()
        {
            try
            {
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
                ServicioSalones.ReservarSalon(reserva);
            }
            catch(InvalidOperationException ex)
            {
                Console.WriteLine("No hay un salón disponible");
            }  
        }
        #endregion Methods
    }
}