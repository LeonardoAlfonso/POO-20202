using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TiendaDeportiva.Models;

namespace TiendaDeportiva.Controllers
{
    [Route("[controller]")]
    public class OtherController : Controller
    {
        
        //https://localhost:5001/Other/Index
        [HttpGet("Index")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
