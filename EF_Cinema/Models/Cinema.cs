using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Cinema.Models
{
    public class Cinema
    {
        public int Id { get; set; }

        public int CinemasNetworkId { get; set; }

        public string Sity { get; set; }

        public string Street { get; set; }

        public string House { get; set; }
    }
}
