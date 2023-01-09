using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Cinema.Models
{
    public class Film
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public int CountryId { get; set; }

        public DateTime Duration { get; set; }
    }
}
