using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmYonetimPaneli.Application.DTO
{
    public class AddFilmSalonDto
    {
        public int filmId { get; set; }
        public int salonId { get; set; }
        public string salonAd { get; set; }    
        public string filmAd { get; set; }    
    }   
}
