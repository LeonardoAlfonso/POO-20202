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
        private int temperatura;
        private int horaLuz;
        
        #endregion Properties

        #region Getters & Setters
        public List<Salon> Salones
        {
            get { return salones; }
            set { salones = value; }
        }
        public Usuario Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        public int Temperatura
        {
            get { return temperatura; }
            set { temperatura = value; }
        }
        public int HoraLuz
        {
            get { return horaLuz; }
            set { temperatura = value; }
        }
        #endregion Getters & Setters

        #region Initialize
        public Edificio()
        {
            salones = new List<Salon>();
        }
        #endregion Initialize

        #region Methods
        public void CambiarHoraLuz()
        {
            Console.WriteLine("Cuántos minutos antes se deben encender las luces de los salones?");
            string minutos = Console.ReadLine();
            HoraLuz = Convert.ToInt32(minutos);
        }
        public void CambiarTemperatura()
        {
            Console.WriteLine("Cuál es la temperatura que debe mantener el salón en uso.");
            string temp = Console.ReadLine();
            Temperatura = Convert.ToInt32(temp);
        }
        public void MostrarDisponibilidad()
        {
            Salones.ForEach(s => {
                Console.WriteLine($"Salón: {s.IdSalon}");
            });
            Console.WriteLine("Elija su salón:");
            string salonElegido = Console.ReadLine();
            Salones.FirstOrDefault(s => s.IdSalon == salonElegido).Reservas.ForEach(r => {
                Console.WriteLine($"Hora Inicio: {r.Dia}");
                Console.WriteLine($"Hora Inicio: {r.HoraInicio}");
                Console.WriteLine($"Hora Inicio: {r.HoraFin}");
            });
        }
        #endregion Methods
    }
}