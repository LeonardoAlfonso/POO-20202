namespace Contenedores.Objetos
{
    public class Usuario
    {
        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Edad { get; set; }
        
    }
}