using FilmYonetimPaneli.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmYonetimPaneli.Domain.Entities
{
    public class Film : BaseEntity
    {
        public String filmAd { get; set; }
        public int filmYapimYil { get; set; }
        public ICollection<Salon> Salonlar { get; set; }
    }
}
