using FilmYonetimPaneli.Application.Interfaces.Repository;
using FilmYonetimPaneli.Persistence.Context;
using FilmYonetimPaneli.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmYonetimPaneli.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer("Server = localhost;Database=FilmYonetimPanelDb;Trusted_Connection=True;TrustServerCertificate=True;"));
            serviceCollection.AddTransient<IFilmRepository, FilmRepository>();
            serviceCollection.AddTransient<ISalonRepository, SalonRepository>();
        }
    }
}
