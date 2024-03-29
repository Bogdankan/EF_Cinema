﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Cinema.Models
{
    public class Cinema
    {
        [Column("cinema_id")]
        public int Id { get; set; }
        public int CinemasNetworkId { get; set; }
        public CinemasNetwork CinemasNetwork { get; set; }
        public int HallId { get; set; }
        public List<Hall> Halls { get; set; }
        public string? Sity { get; set; }
        public string? Street { get; set; }
        public string? House { get; set; }
    }
}
