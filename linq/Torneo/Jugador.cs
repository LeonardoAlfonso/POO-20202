namespace linq.Torneo
{
    public class Jugador
    {
        #region Properties  
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public int Posicion { get; set; }
        public double Ataque { get; set; }
        public double Defensa { get; set; }
        public double Goles { get; set; }
        public double Asistencias { get; set; }

        #endregion Properties

        #region Initialize
        public Jugador(string n, int e, int p, double a, double d, int g, int s) 
        {
            this.Nombre = n;
            this.Edad = e;
            this.Posicion = p;
            this.Ataque = a;
            this.Defensa = d;
            this.Goles = g;
            this.Asistencias = s;
        }
        #endregion Initialize

    }
}