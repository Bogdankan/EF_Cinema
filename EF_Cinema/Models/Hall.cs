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

        public int PlacesCount { get; set; }

        public int RowsCount { get; set; }
    }
}
