using Banco.Cuentas;

namespace Banco.Usuarios
{
    public class Cliente
    {
        #region Properties
        public string Nombre { get; set; }
        private string documento;
        public string UserName { get; set; }
        private int password;
        private string celular;
        private CuentaAhorros cuentaPrincipal;

        #endregion Properties

        #region Getters & Setters

        public string Documento
        {
            get { return documento; }
            set { documento = value; }
        }
        public int Password
        {
            get { return password; }
            set { password = value; }
        }
        public string Celular
        {
            set { celular = value; }
        }
        public CuentaAhorros CuentaPrincipal
        {
            get { return cuentaPrincipal; }
            set 
            { 
                if (cuentaPrincipal == null)
                {
                    cuentaPrincipal = value; 
                }
            }
        }
        #endregion Getters & Setters


    }
}