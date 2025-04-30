using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace modul10_103022300136
{
    [ApiController]
    [Route("api/[controller]")]
    public class movieController : ControllerBase
    {
        private static List<movie> daftarMovie = new List<movie>
        {
            new movie("The Shawshank Redemption", "Frank Darabont", new List<string> {"Tim Robbins", "Morgan Freeman", "Bob Gunton"}, "A banker convicted of uxoricide forms a friendship over a quarter century with a hardened convict, while maintaining his innocence and trying to remain hopeful through simple compassion."),
            new movie("The GodFather", "Francis Ford Coppola", new List<string> {"Marlon Brando", "Al Pacino", "James Caan"}, "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son."),
            new movie("The Dark Knight", "Christopher Nolan", new List<string> {"Christian Bale", "Heath Ledger", "Aaron Eckhart"}, "When a menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman, James Gordon and Harvey Dent must work together to put an end to the madness.")
        };

        // GET: api/movie
        [HttpGet]
        public ActionResult<List<movie>> Getmovie()
        {
            return daftarMovie;
        }

        // GET: api/movie/{index}
        [HttpGet("{index}")]
        public ActionResult<movie> GetmovieByIndex(int index)
        {
            if (index < 0 || index >= daftarMovie.Count)
            {
                return NotFound();
            }
            return daftarMovie[index];
        }

        // POST: api/movie
        [HttpPost]
        public ActionResult<List<movie>> Postmovie([FromBody] movie movieBaru)
        {
            daftarMovie.Add(movieBaru);
            return daftarMovie;
        }

        // DELETE: api/movie/{index}
        [HttpDelete("{index}")]
        public ActionResult<List<movie>> Deletemovie(int index)
        {
            if (index < 0 || index >= daftarMovie.Count)
            {
                return NotFound();
            }
            daftarMovie.RemoveAt(index);
            return daftarMovie;
        }
    }
}

