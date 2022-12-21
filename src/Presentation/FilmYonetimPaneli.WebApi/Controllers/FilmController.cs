using FilmYonetimPaneli.Application.Interfaces.Repository;
using FilmYonetimPaneli.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.SqlServer.Storage.Internal;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmYonetimPaneli.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmController : ControllerBase
    {
        private readonly IFilmRepository filmRepository;
        public FilmController(IFilmRepository filmRepository)
        {
            this.filmRepository = filmRepository;

        }
        [HttpGet]
        public async Task<IActionResult> GetFilms()
        {
           var allList = await filmRepository.GetAllFilms();
            return Ok(allList); 
        }
        [HttpGet("{x}/{y}")]
        public async Task<IActionResult> GetFilmYear(int x , int y)
        {
            var films = await filmRepository.GetFilmListBeetweenYears(x,y);
            
            return Ok(films);
        }
        [HttpPost]
        public async Task<IActionResult> Post(Film film)
        {
            var postList = await filmRepository.AddAsync(film);
            return Ok(postList);    
        }
        [HttpDelete("id")]
        public void Delete(int id)
        {
            filmRepository.Delete(id);
        }

        [HttpPut]
        public void Update(Film film)
        {
            filmRepository.Update(film);
        }
    }
}
