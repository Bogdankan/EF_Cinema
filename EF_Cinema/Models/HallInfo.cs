using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Cinema.Models
{
    public class HallInfo
    {
        public int Id { get; set; }
        public string? Color { get; set; }
        public int Number { get; set; }
        public int PlacesCount { get; set; }
        public int RowsCount { get; set; }
        public int HallId { get; set; }
        public virtual Hall Hall { get; set; }
    }
}
