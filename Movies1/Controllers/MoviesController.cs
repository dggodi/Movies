using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Microsoft.AspNetCore.Mvc;
using Movies1.Model;
//using Microsoft.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Movies1.Data;

namespace Movies1.Api.Controllers
{
   [Route("api/[controller]")]
    public class MoviesController : Controller
    {
        MoviesData _db;

        public MoviesController(MoviesData db)
        {
            _db = db;
        }
/* 
        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            return _db.Movies;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Thread.Sleep(1000);
            var movie = _db.Movies.FirstOrDefault(m => m.Id == id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return new ObjectResult(movie);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Movie newMovie)
        {
            if (ModelState.IsValid)
            {
                _db.Movies.Add(newMovie);
                _db.SaveChanges();
                return CreatedAtRoute(new { controller = "Movies", id = newMovie.Id }, newMovie);
            }
            return HttpBadRequest(ModelState);
        }

        [HttpPut]
        public IActionResult Put([FromBody] Movie updatedMovie)
        {
            if (ModelState.IsValid)
            {
                _db.Movies.Attach(updatedMovie).State = EntityState.Modified;
                _db.SaveChanges();
                return new ObjectResult(updatedMovie);
            }
            return HttpBadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var movie = _db.Movies.FirstOrDefault(m => m.Id == id);
            if (movie != null)
            {
                _db.Movies.Remove(movie);
                _db.SaveChanges();
                return new ObjectResult(movie);
            }
            return HttpNotFound();
        }*/
    }
    
}
