using FilmYonetimPaneli.Application.Interfaces.Repository;
using FilmYonetimPaneli.Domain.Common;
using FilmYonetimPaneli.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmYonetimPaneli.Persistence.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T: BaseEntity
    {
        private readonly ApplicationDbContext dbContext;

        public GenericRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<T> AddAsync(T entity)
        {
            await dbContext.Set<T>().AddAsync(entity);
            await dbContext.SaveChangesAsync();
            return entity;
        }

        public void Delete(int id)
        {
            dbContext.Set<T>().Remove(dbContext.Set<T>().Single(i=>i.Id == id));
            dbContext.SaveChanges();
        }

        public async Task<List<T>> GetAllAsync()
        {
           return await dbContext.Set<T>().ToListAsync();
        }

        public  void Update(T entity)
        {
            dbContext.Attach(entity);
            dbContext.Entry(entity).State = EntityState.Modified;
        }
    }
}