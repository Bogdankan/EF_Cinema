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
        public virtual Cinema Cinema { get; set; }
        public int? SessionId { get; set; }
        public virtual List<Session> Sessions { get; set; }
        public virtual HallInfo? Info { get; set; } 
    }
}
