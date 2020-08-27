namespace Ejemplo2.Banco.Cuentas
{
    public class CuentaAhorros
    {
        #region Properties
        private int clave;
        private double saldo;
        private string referencia;

        #endregion Properties


        #region Getters & Setters
        public int Clave
        {
            // get { return clave; }
            set 
            {
                if(value != clave)
                {
                    clave = value; 
                }
            }
        }
        public double Saldo
        {
            set { saldo = value; }
        }
        public string Referencia
        {
            get { return referencia; }
            set 
            { 
                referencia = value.ToUpper(); 
            }
        } 
        #endregion Getters & Setters

        #region Métodos
        public double GetSaldo(int claveAcceso, string referenciaUsuario)
        {
            double response = 0;
            if (this.clave == claveAcceso && referenciaUsuario.ToUpper() == Referencia)
            {
                response = this.saldo;
            }
            return response;
        }
        #endregion Métodos
    }
}