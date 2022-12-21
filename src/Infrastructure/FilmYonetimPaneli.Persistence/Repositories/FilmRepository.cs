using FilmYonetimPaneli.Application.Interfaces.Repository;
using FilmYonetimPaneli.Domain.Entities;
using FilmYonetimPaneli.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmYonetimPaneli.Persistence.Repositories
{
    public class FilmRepository : GenericRepository<Film>, IFilmRepository
    {
        private readonly ApplicationDbContext dbContext;
        public FilmRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }

        public Task<List<Film>> GetFilmListBeetweenYears(int x , int y)
        {
            var liste =  dbContext.Films.Where(a =>a.filmYapimYil > x && a.filmYapimYil <y).Include(i => i.Salonlar.Select(i=>i.salonAd)).ToListAsync();
            return liste;
        }
        public async Task<Film> GetByIdAsync(int Id)
        {
            return await dbContext.Films.Include(x => x.Salonlar.Select(a=>a.salonAd)).FirstOrDefaultAsync(a => a.Id == Id);
        }

        public async Task<List<Film>> GetAllFilms()
        {
            return await dbContext.Films.Include(x => x.Salonlar).ToListAsync();
        }
       
    }
}
