namespace Banco.Cuentas
{
    public class CuentaAhorros
    {
        #region Properties
        public long NumeroCuenta { get; set; }
        private double saldo;
        private int clave;

        private double tope;
        public double Tope
        {
            get { return tope; }
            set { tope = value; }
        }
        
        #endregion Properties

        #region Getters & Setters
        public double Saldo
        {
            get { return saldo; }
        }
        public int Clave
        {
            get { return clave; }
            set { clave = value; }
        }
        #endregion Getters & Setters

        #region Methods
        public void IngresarSaldo(double dinero)
        {
            if (dinero > 0 && dinero < Tope)
            {
                this.saldo += dinero;
            }
        }
        #endregion Methods
    }
}
