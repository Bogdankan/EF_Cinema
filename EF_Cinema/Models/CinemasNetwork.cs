using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Cinema.Models
{
    public class CinemasNetwork
    {
        [Column("cinemasnetwork_id")]
        public int Id { get; set; }
        public string? Name { get; set; }
        public int CinemaId { get; set; }
        public List<Cinema> Cinemas { get; set; }
    }
}
