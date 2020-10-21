namespace Patrones.Singleton
{
    public sealed class BaseDatos2
    {
        private static BaseDatos2 instancia;
        private BaseDatos2() { }
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

        public static BaseDatos2 GetData()
        {
            if (instancia == null)
            {
                instancia = new BaseDatos2();
            }
            return instancia;
        }

    }
} 