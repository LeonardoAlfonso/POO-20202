using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Libreria.Models;
using Libreria.Services;
using Libreria.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Libreria.Controllers
{
    [Route("[controller]")]
    public class AutorController : Controller
    {
        #region Properties
        private readonly LibreriaDBContext dBContext;
        #endregion

        #region Constructor
        public AutorController(LibreriaDBContext dBContext)
        {
            this.dBContext = dBContext;
        }
        #endregion

        [HttpGet("BuscadorAutores")]
        public IActionResult Buscador(AutorModel? autor)
        {
            AutorBuscadorViewModel vm = new AutorBuscadorViewModel();
            if (autor.Nombre != null)
                vm.HayUsuario = true;
            vm.AutorBusqueda = autor ?? new AutorModel();
            return View(vm);
        }

        public async Task<IActionResult> BuscarAutor(AutorBuscadorViewModel autorVm)
        {
            AutorModel Autor = new AutorModel();
            try
            {
                List<AutorModel> autores = await dBContext.Autores.ToListAsync();
                Autor = autores.First(a => a.Nombre == autorVm.AutorBusqueda.Nombre);
                return RedirectToAction("Buscador", "Autor", Autor);
            }
            catch(InvalidOperationException)
            {
                return RedirectToAction("Buscador", "Autor", null);
            }
        }
    }
}
