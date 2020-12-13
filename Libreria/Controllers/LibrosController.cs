using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Libreria.Models;
using Libreria.Services;
using Libreria.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;

namespace Libreria.Controllers
{
    [Route("[controller]")]
    public class LibrosController : Controller
    {
        #region Properties
        private readonly LibreriaDBContext dBContext;
        private IMemoryCache _cache;
        #endregion

        #region Constructor
        public LibrosController(LibreriaDBContext dBContext, IMemoryCache memoryCache)
        {
            this.dBContext = dBContext;
            _cache = memoryCache;
        }
        #endregion
        


        //https://localhost:5001/Libros/ListaLibros
        [HttpGet("ListaLibros")]
        public async Task<IActionResult> Index()
        {
            

            var cacheEntryOptions = new MemoryCacheEntryOptions()
            // Keep in cache for this time, reset time if accessed.
            .SetSlidingExpiration(TimeSpan.FromMinutes(10));
            _cache.Set("test", "Holi", cacheEntryOptions);

            string cacheEntry = "";
            if (_cache.TryGetValue("test", out cacheEntry))
            {
                Console.WriteLine(cacheEntry);
            }

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
