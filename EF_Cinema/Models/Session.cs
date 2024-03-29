﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Cinema.Models
{
    public class Session
    {
        public int Id { get; set; }
        public int? TicketId { get; set; }
        public List<Ticket> Tickets { get; set; }
        public int FilmId { get; set; }
        public Film Film { get; set; }
        public int HallId { get; set; }
        public Hall Hall { get; set; }
        public DateTime DateTime { get; set; }
    }
}
