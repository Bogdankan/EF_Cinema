using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Cinema.Models
{
    public class Hall
    {
        public int Id { get; set; }
        public int CinemaId { get; set; }
        public Cinema Cinema { get; set; }
        public int? SessionId { get; set; }
        public List<Session> Sessions { get; set; }
        public HallInfo? Info { get; set; }
    }
}
