namespace Patrones.Singleton
{
    public sealed class BaseDatos
    {
        private readonly static BaseDatos instancia = new BaseDatos();
        private BaseDatos() { }
        private string port;
        private string username;
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        
        public string Port
        {
            get { return port; }
            set { port = value; }
        }
    
        public static BaseDatos Instancia
        {
            get
            {
                return instancia;
            }
        }
    }
} 