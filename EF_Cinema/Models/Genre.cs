using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Cinema.Models
{
    public class Genre
    {
        public int Id { get; set; }
        public int? FilmId { get; set; }
        public virtual List<Film> Films { get; set; }
        public virtual List<FilmGenre> FilmGenres { get; set; }
        public string? Name { get; set; }
    }
}
