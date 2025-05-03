using Microsoft.AspNetCore.Mvc;
using modul10_103022330068.Model;
namespace modul10_103022330068.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : ControllerBase
    {
        public static readonly List<Movie> movies = new()
         {
            new Movie("The Godfather", "Francis Ford Coppola", new List<string>{"Marlon Brando", "Al pachino, James Caan" }, "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son."),
            new Movie("The Dark Knight", "Christopher Nolan", new List<string>{"Christian Bale", "Heath Ledger, Aaron Eckhart" }, "When the menace known as the Joker emerges from his mysterious past, he wreaks havoc and chaos on the people of Gotham. The Dark Knight must accept one of the greatest psychological and physical tests of his ability to fight injustice."),
        };




        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<Movie>))]
        public IActionResult Get()
        {
            return Ok(movies);
        }

        [HttpGet("{index}")]
        public ActionResult<Movie> GetByIndex(int index)
        {
            if (index < 0 || index >= movies.Count)
                return NotFound("film tidak ditemukan");

            return movies[index];
        }
        [HttpPost]
        public ActionResult<List<Movie>> Post(Movie mahasiswaBaru)
        {
            movies.Add(mahasiswaBaru);
            return movies;
        }

        [HttpDelete("{index}")]
        public ActionResult<List<Movie>> Delete(int index)
        {
            if (index < 0 || index >= movies.Count)
                return NotFound("Film tidak ditemukan");

            movies.RemoveAt(index);
            return movies;
        }
    }
}
