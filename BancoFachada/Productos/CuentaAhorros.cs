namespace BancoFachada.Productos
{
    public class CuentaAhorros
    {
        #region Properties
        public long NumeroCuenta { get; set; }
        private double saldo;
        private int clave;
        private double tope;

        #endregion Properties

        #region Getters & Setters
        public double Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }
        public int Clave
        {
            get { return clave; }
            set { clave = value; }
        }

        public double Tope
        {
            get { return tope; }
            set { tope = value; }
        }
        #endregion Getters & Setters
    }
}

