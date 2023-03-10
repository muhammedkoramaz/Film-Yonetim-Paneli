using FilmYonetimPaneli.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmYonetimPaneli.Application.Interfaces.Repository
{
    public interface IGenericRepository <T> where T : BaseEntity
    {
        Task<List<T>> GetAllAsync();
        Task<T> AddAsync(T entity);
        void Update(T entity);
        void Delete(int id);
    }
}
