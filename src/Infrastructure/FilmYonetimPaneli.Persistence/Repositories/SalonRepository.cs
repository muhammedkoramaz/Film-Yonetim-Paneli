using FilmYonetimPaneli.Application.Interfaces.Repository;
using FilmYonetimPaneli.Domain.Entities;
using FilmYonetimPaneli.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmYonetimPaneli.Persistence.Repositories
{
    public class SalonRepository : GenericRepository<Salon>, ISalonRepository
    {
        public SalonRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
