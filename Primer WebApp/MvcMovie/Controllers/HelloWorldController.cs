using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;
using MvcMovie.ViewModels;
using System.Collections.Generic;
using System.Net;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace MvcMovie.Controllers
{
    [Route("[controller]")]
    public class HelloWorldController : Controller
    {

        #region Properties
        private readonly TiendaDBContext dBContext;
        #endregion Properties

        #region Constructor
        public HelloWorldController(TiendaDBContext dBContext)
        {
            this.dBContext = dBContext;
        }
        #endregion Constructor

        // 
        // GET: /HelloWorld/
        
        [HttpGet("{id}")]
        public string Index(long id)
        {
            return id.ToString();
        }

        [HttpGet("Test")]
        public IActionResult Test(long id)
        {
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 
        // [HttpPut]
        // public IActionResult Welcome([FromBody] Movie movie)
        // {
        //     return View(movie);
        // }

        [HttpGet("Welcome")]
        public async Task<IActionResult> Welcome()
        {
            Movie movie = new Movie()
            {
                Title = "Yo no fui",
                Genre = "Comedia",
                Price = 789
            };
            Movie movie2 = new Movie()
            {
                Title = "Yo no fui",
                Genre = "Comedia",
                Price = 789
            };
            dBContext.peliculas.Add(movie);
            await dBContext.SaveChangesAsync();
            List<Movie> movies = new List<Movie>();
            movies.Add(movie);
            movies.Add(movie2);
            MovieGenreViewModel vm = new MovieGenreViewModel();
            vm.Movies = movies;
            return View(vm);
        }

        [HttpGet("CreateView")]
        public IActionResult PostTest()
        {
            return View();
        }

        [HttpPost("Create")]
        public string Create(Movie movie)
        {
            return movie.Title;
        }
    }
}
