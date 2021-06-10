using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tema7.Model;

namespace Tema7.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        [HttpGet]
        public Movie[] Get()
        {
            List<Movie> movies = new List<Movie>()
            {
                new Movie() { Id = Guid.NewGuid(), Name = "Movie 1" , Genre = "1"},
                new Movie() { Id = Guid.NewGuid(), Name = "Movie 2" , Genre = "2"},
                new Movie() { Id = Guid.NewGuid(), Name = "Movie 3" , Genre = "3"},
                new Movie() { Id = Guid.NewGuid(), Name = "Movie 4" , Genre = "4"},
                new Movie() { Id = Guid.NewGuid(), Name = "Movie 5" , Genre = "5"},
                new Movie() { Id = Guid.NewGuid(), Name = "Movie 6" , Genre = "6"},
                new Movie() { Id = Guid.NewGuid(), Name = "Movie 7" , Genre = "7"},
                new Movie() { Id = Guid.NewGuid(), Name = "Movie 8" , Genre = "8"},
                new Movie() { Id = Guid.NewGuid(), Name = "Movie 9" , Genre = "9"},
                new Movie() { Id = Guid.NewGuid(), Name = "Movie 10" , Genre = "10"},
                new Movie() { Id = Guid.NewGuid(), Name = "Movie 11" , Genre = "11"},
                new Movie() { Id = Guid.NewGuid(), Name = "Movie 12" , Genre = "12"},
            };

            return movies.ToArray();
        }
    }

}
