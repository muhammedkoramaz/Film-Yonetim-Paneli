using FilmYonetimPaneli.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmYonetimPaneli.Domain.Entities
{
    public class Salon : BaseEntity
    {
        public String salonAd { get; set; }

        public ICollection<Film> Filmler { get; set; }

    }
}
