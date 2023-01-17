using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Cinema.Models
{
    public class Film
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? CountryId { get; set; }
        public Country Country { get; set; }
        public int? SessionId { get; set; }        
        public List<Session> Sessions { get; set; }
        public int GenreId { get; set; }
        public List<Genre> Genres { get; set; }
        public List<FilmGenre> FilmGenres { get; set; }
        public DateTime Duration { get; set; }
    }
}
