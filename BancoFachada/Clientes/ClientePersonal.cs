using BancoFachada.Productos;

namespace BancoFachada.Clientes
{
    public class Cliente
    {
        #region Properties
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Celular { get; set; }
        public string Documento { get; set; }
        public CuentaAhorros MiCuenta { get; set; }
        #endregion Properties

        #region Initialize
        public Cliente (CuentaAhorros cuenta)
        {
            MiCuenta = cuenta;
        }
        #endregion Initialize
    }
}