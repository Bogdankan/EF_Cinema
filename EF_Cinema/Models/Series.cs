using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Cinema.Models
{
    public class Series : Film
    {
        public int EpisodeCount { get; set; }
        public int SeasonsCount { get; set; }
    }
}
