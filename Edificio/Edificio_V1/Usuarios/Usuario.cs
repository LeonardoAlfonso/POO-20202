namespace Edificio_V1.Usuarios
{
    public class Usuario
    {
        #region Properties
        private string nombre;
        private bool isAdmin;
        #endregion Properties

        #region Getters & Setters
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public bool IsAdmin
        {
            get { return isAdmin; }
            set { isAdmin = value; }
        }
        #endregion Getters & Setters

        #region Initialize
        public Usuario()
        {
            this.IsAdmin = false;
        }
        #endregion Initialize

        #region Methods
        #endregion Methods
    }
}