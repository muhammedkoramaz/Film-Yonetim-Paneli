using FilmYonetimPaneli.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmYonetimPaneli.Application.Interfaces.Repository
{
    public interface IFilmRepository : IGenericRepository <Film>
    {
       public Task<List<Film>> GetFilmListBeetweenYears(int x, int y);
       //public  Task<Film> GetByIdAsync(int Id);
       public Task<List<Film>> GetAllFilms();
    }
}
