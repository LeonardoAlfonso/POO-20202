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
        private GestorEdificio servicioEdificio;
        
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
                Console.WriteLine("A continuación, Verá la lista de los salones del edificio:");
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
        
        public void VisualizarSalon()
        {
            try
            {
                Console.WriteLine("A continuación, Verá la lista de los salones del edificio:");
                ServicioSalones.RetornarSalones().ForEach(s => Console.WriteLine(s));
                Console.WriteLine("Elija su salón:");
                string salonElegido = Console.ReadLine();
                Console.WriteLine("A qué hora desea ver el salón?: ");
                string horaSeleccionada = Console.ReadLine();
                Console.WriteLine("A qué minutos desea ver el salón?: ");
                string minutosSeleccionados = Console.ReadLine();
                Salon salon = servicioEdificio.RetornarEstadoSalon(salonElegido, horaSeleccionada, minutosSeleccionados);
                Console.WriteLine("El estado del salón es: ");
                Console.WriteLine("La temperatura es " + salon.Temperatura);
                Console.WriteLine("La luz está " + (salon.Luz ? "encendida" : "apagada"));
            }
            catch(InvalidOperationException ex)
            {
                Console.WriteLine("Este salón no existe");
            } 

        }
        #endregion Methods
    }
}
