using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Cinema.Models
{
    [Table("Countrie")]
    public class Country
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        //public int? FilmId { get; set; }
        public virtual List<Film> Films { get; set; }
    }
}
