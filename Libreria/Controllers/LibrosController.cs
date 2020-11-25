using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Libreria.Models;
using Libreria.Services;
using Libreria.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Libreria.Controllers
{
    [Route("[controller]")]
    public class LibrosController : Controller
    {
        #region Properties
        private readonly LibreriaDBContext dBContext;
        #endregion

        #region Constructor
        public LibrosController(LibreriaDBContext dBContext)
        {
            this.dBContext = dBContext;
        }
        #endregion
        


        //https://localhost:5001/Libros/ListaLibros
        [HttpGet("ListaLibros")]
        public async Task<IActionResult> Index()
        {
            LibrosIndexViewModel vm = new LibrosIndexViewModel();
            try
            {
                vm.Libros = await dBContext.Libros.ToListAsync();
                if (vm.Libros.Count <= 3)
                    throw new Exception("No hay libros");
                return View(vm);
            }
            catch (Exception e)
            {
                vm.HayLibros = false;
                return View(vm);
            }
        }
    }
}
