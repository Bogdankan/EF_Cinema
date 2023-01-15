using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Cinema.Models
{
    [Table("Film")]
    public class Film
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? CountryId { get; set; }
        public virtual Country Country { get; set; }
        public int? SessionId { get; set; }        
        public virtual List<Session> Sessions { get; set; }
        public int GenreId { get; set; }
        public virtual List<Genre> Genres { get; set; }
        public virtual List<FilmGenre> FilmGenres { get; set; }
        public DateTime Duration { get; set; }
    }
}
