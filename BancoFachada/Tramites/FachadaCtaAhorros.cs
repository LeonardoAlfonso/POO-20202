using System;
using BancoFachada.Clientes;
using BancoFachada.Productos;

namespace BancoFachada.Tramites
{
    public class FachadaCtaAhorros
    {
        #region Properties
        public string NombreCliente { get; set; }
        public string OpcionCliente { get; set; }
        public string ApellidoCliente { get; set; }
        public string DocumentoCliente { get; set; }
        public string CelularCliente { get; set; }
        public string SaldoCliente { get; set; }
        public string ClaveCliente { get; set; }
        private double topeCuentas;

        
        #endregion Properties

        #region Getters & Setters
        public double TopeCuentas
        {
            set 
            { 
                topeCuentas = value; 
            }
        }
        #endregion Getters & Setters

        #region Initialize
        public FachadaCtaAhorros()
        {
            TopeCuentas = 500000;
        }
        #endregion Initialize

        #region Methods
        public void SaludarCliente()
        {
            Console.WriteLine("Bienvenido al banco\n Por favor digíte su nombre: ");
            NombreCliente = Console.ReadLine();
            Console.WriteLine("Qué trámite desea hacer señor " + NombreCliente);
            Menu();
        }

        public void Menu()
        {
            Console.WriteLine("Los trámites del banco son: \n1-) Crear Cuenta Ahorros");
            OpcionCliente = Console.ReadLine();
            if(OpcionCliente == "1")
            {
                CrearCuentaAhorros();
            }
            else
            {
                Console.WriteLine("Esta opción no existe");
            }
        }

        private void CrearCuentaAhorros()
        {
            if(PedirDatosCliente())
            {
                if (PedirDatosCuenta())
                {
                    var random = new Random();
                    long numeroCuenta = (long)random.NextDouble();
                    CuentaAhorros cuentaCliente = new CuentaAhorros()
                    {
                        Saldo = Convert.ToDouble(SaldoCliente),
                        Clave = Convert.ToInt32(ClaveCliente),
                        NumeroCuenta = numeroCuenta,
                        Tope = topeCuentas
                    };
                    Cliente cliente = new Cliente(cuentaCliente);
                }
            }
        }

        private bool PedirDatosCliente()
        {
            bool respuesta = false;
            Console.WriteLine("A continuación, se le solicitarán unos datos para la creación de su cuenta");
            Console.WriteLine("Cuál es su apellido");
            ApellidoCliente = Console.ReadLine();
            Console.WriteLine("Cuál es su documento");
            DocumentoCliente = Console.ReadLine();
            Console.WriteLine("Cuál es su celular");
            CelularCliente = Console.ReadLine();
            respuesta = ValidateCliente();
            return respuesta;
        }

        private bool ValidateCliente()
        {
            long longnum = 0;
            //Validaciones
            if (NombreCliente == "" || ApellidoCliente == "" || DocumentoCliente == "" || CelularCliente == "")
            {
                return false;
            }
            else if(!long.TryParse(DocumentoCliente, out longnum) && !long.TryParse(CelularCliente, out longnum))
            {
                return false;
            }
            else if(CelularCliente.Length != 10)
            {
                return false;
            }

            return true;
        }

        private bool PedirDatosCuenta()
        {
            bool respuesta = false;
            Console.WriteLine("A continuación, se le solicitarán unos datos adicionales");
            Console.WriteLine("Con cuánto dinero iniciará la cuenta?");
            SaldoCliente = Console.ReadLine();
            Console.WriteLine("Digite su clave");
            ClaveCliente = Console.ReadLine();
            respuesta = ValidateCuenta();
            return respuesta;
        }

        private bool ValidateCuenta()
        {
            long saldo = 0;
            //Validaciones
            if (!long.TryParse(SaldoCliente, out saldo))
            {
                return false;
            }
            else if (saldo <= 0)
            {
                return false;
            }
            else if (ClaveCliente.Length != 4)
            {
                return false;
            }

            return true;
        }
        #endregion Methods
    }
}