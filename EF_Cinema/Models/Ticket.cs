using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Cinema.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public int HallNumber { get; set; }
        public int PlaceNumber { get; set; }
        public int RowNumber { get; set; }
        public int SessionId { get; set; }
        public Session Session { get; set; }
        public int Price { get; set; }
    }
}
