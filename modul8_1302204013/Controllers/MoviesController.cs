using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace modul8_1302204013.Controllers
{
    [Route("api/[controller]")]
    public class MoviesController : Controller
    {

        private static List<string> Stars1 = new List<string>
        {
            "Tim Robbins", "Morgan Freeman", "Bob Gunton", "William Sadler"
        };

        private static List<string> Stars2 = new List<string>
        {
            "Marlon Brando", "Al Pacino", "James Caan", "Diane Keaton"
        };

        private static List<string> Stars3 = new List<string>
        {
            "Christian Bale", "Heath Ledger", "Aaron Eckhart", "Michael Caine"
        };



        List<Movie> film = new List<Movie>();

        public MoviesController()
        {
            film.Add(new Movie { Title = "The Shawshank Redemption", Description = "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.", Director = "Frank Darabont", Stars = Stars1, id = 1 });
            film.Add(new Movie { Title = "The Godfather ", Description = "The aging patriarch of an organized crime dynasty in postwar New York City transfers control of his clandestine empire to his reluctant youngest son.", Director = "Francis Ford Coppola", Stars = Stars2, id = 2 });
            film.Add(new Movie { Title = "The Dark Knight", Description = "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.", Director = "Christopher Nolan", Stars = Stars3, id = 3 });
        }

        // GET: api/values
        [HttpGet]
        public List<Movie> Get()
        {
            return film;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Movie Get(int id)
        {
            return film.Where(X => X.id == id).FirstOrDefault();
        }

        // POST api/values
        [HttpPost]
        public async Task<ActionResult<Movie>> Post(Movie movie)
        {

            film.Add(movie);
            return Ok(film);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Movie>> Delete(int id)
        {
            var movie = film.Find(x => x.id == id);
            film.Remove(movie);
            return Ok(film);
        }
    }
}

