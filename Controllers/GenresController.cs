using Microsoft.AspNetCore.Mvc;
using MoviesAPI.Entities;
using MoviesAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesAPI.Controllers
{
    [Route("api/genres")]
    public class GenresController : ControllerBase
    {
        private readonly IRepository repository;

        public GenresController(IRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        [HttpGet("list")]
        [HttpGet("/allgenres")]
        public async Task<ActionResult<List<Genre>>> Get()
        {
            return await repository.GetAllGenres();
        }

        [HttpGet("{Id}")]
        public ActionResult<Genre> Get(int id)
        {
            var genre = repository.GetGenreById(id);

            if (genre == null)
            {
                return NotFound();
            }

            return genre;
        }

        [HttpPost]
        public ActionResult Post()
        {
            return NoContent();
        }

        [HttpPut]
        public ActionResult Put()
        {
            return NoContent();
        }

        [HttpDelete]
        public ActionResult Delete()
        {
            return NoContent();
        }
    }
}
