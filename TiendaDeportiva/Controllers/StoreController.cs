using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TiendaDeportiva.Models;
using TiendaDeportiva.Services;
using TiendaDeportiva.ViewModels;

namespace TiendaDeportiva.Controllers
{
    //https://localhost:5001/Store
    [Route("[controller]")]
    public class StoreController : Controller
    {

        #region Properties
        private readonly TiendaDeportivaDBContext dBContext;
        #endregion

        #region Constructor
        public StoreController(TiendaDeportivaDBContext dBContext)
        {
            this.dBContext = dBContext;
        }

        #endregion Constructor

        //https://localhost:5001/Store/TestStore
        [HttpGet("TestStore")]
        public string TestStore()
        {
            return "Mi primer metodo";
        }

        //https://localhost:5001/Store/SayHello/name
        [HttpGet("SayHello/{name}")]
        public string SayHello(string name)
        {
            return "Hola Sr/Sra. " + name;
        }

        //https://localhost:5001/Store/TestPost/
        [HttpPost("TestPost")]
        public string TestPost([FromBody]Product product)
        {
            return product.Nombre;
        }

        //https://localhost:5001/Store/ActionPost/
        [HttpPost("ActionPost")]
        public IActionResult ActionPost([FromBody]Product product)
        {
            return Ok(product);
        }

        //https://localhost:5001/Store/InfoProduct/
        [HttpGet("InfoProduct/{nombre}/{apellido}")]
        public IActionResult InfoProduct(string nombre, string apellido)
        {
            ViewData["nombre"] = nombre;
            ViewData["apellido"] = apellido;
            return View();
        }

        //https://localhost:5001/Store/Details/nombreCliente
        [HttpGet("Details/{nombreCliente}")]
        public IActionResult Details(string nombreCliente)
        {
            DetailsViewModel DetailsView = new DetailsViewModel();
            Product product = new Product()
            {
                Nombre = "Raqueta",
                Precio = 320000,
                Color = "Blanca"
            };
            DetailsView.product = product;
            DetailsView.NombreCliente = nombreCliente;
            return View(DetailsView);
        }

        //https://localhost:5001/Store/ListProducts
        [HttpGet("ListProducts")]
        public IActionResult ListProducts()
        {
            ListProductViewModel ListProductsView = new ListProductViewModel();
            Product product1 = new Product()
            {
                Nombre = "Raqueta",
                Precio = 320000,
                Color = "Blanca"
            };
            Product product2 = new Product()
            {
                Nombre = "Balon Futbol",
                Precio = 100000,
                Color = "W/B"
            };
            Product product3 = new Product()
            {
                Nombre = "Tennis",
                Precio = 200000,
                Color = "Azules"
            };
            ListProductsView.Products.Add(product1);
            ListProductsView.Products.Add(product2);
            ListProductsView.Products.Add(product3);
            return View(ListProductsView);
        }

        //https://localhost:5001/Store/CreateProduct
        [HttpGet("CreateProduct")]
        public IActionResult CreateProduct()
        {
            return View();
        }

        //https://localhost:5001/Store/SaveProduct/
        [HttpPost("SaveProduct")]
        public IActionResult SaveProduct(Product product)
        {
            return Ok(product.Color);
        }

        //https://localhost:5001/Store/CreateUser
        [HttpGet("CreateUser")]
        public async Task<IActionResult> CreateUser()
        {
            UsuarioModel Usuario = new UsuarioModel()
            {
                Nombre = "Pepito",
                Apellido = "Perez",
                Edad = 54
            };
            dBContext.usuariosla.Add(Usuario);
            await dBContext.SaveChangesAsync();

            return Ok(Usuario.Id.ToString());
        }

        //https://localhost:5001/Store/ListUsers
        [HttpGet("ListUsers")]
        public async Task<IActionResult> ListUsersAsync()
        {
            ListUsersViewModel vm = new ListUsersViewModel();
            vm.Users = await dBContext.usuariosla.ToListAsync();
            // vm.Users = vm.Users.Where(u => u.Nombre == "Gustavo").ToList();
            return View(vm);
        }

        //https://localhost:5001/Store/DeleteUser/1
        [HttpGet("DeleteUser/{id}")]
        public async Task<IActionResult> DeleteUser(long id)
        {
            try
            {
                UsuarioModel usuario = await dBContext.usuariosla.FindAsync(id);
                if (usuario == null)
                    throw new Exception("Usuario no encontrado");

                dBContext.usuariosla.Remove(usuario);
                await dBContext.SaveChangesAsync();
                return Ok("Usuario Borrado");
            }
            catch (Exception e)
            {
                return Content(e.Message);
            }
        }

        //https://localhost:5001/Store/DeleteUser/1
        [HttpPut("UpdateUser/{id}")]
        public async Task<IActionResult> UpdateUser(long id, UsuarioModel Usuario)
        {
            UsuarioModel usuario = await dBContext.usuariosla.FindAsync(id);
            if (usuario == null)
                throw new Exception("Usuario no encontrado");
            
            Usuario.Id = id;
            dBContext.Entry(Usuario).State = EntityState.Modified;
            await dBContext.SaveChangesAsync();
            return Content("Usuario Modificado");
        }

    }
}