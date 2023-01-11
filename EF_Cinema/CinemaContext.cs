using EF_Cinema.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EF_Cinema
{
    public class CinemaContext : DbContext
    {
        public DbSet<Film> Films { get; set; } = null!;
        public DbSet<Series> Series { get; set; } = null!;


        public CinemaContext(DbContextOptions<CinemaContext> options) : base(options)
        {
            //Database.EnsureDeleted();
            //Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Cinema>();
            //modelBuilder.Entity<CinemasNetwork>(); 
            //modelBuilder.Entity<Country>();
            //modelBuilder.Entity<Film>();
            //modelBuilder.Entity<Genre>();
            //modelBuilder.Entity<Hall>();
            //modelBuilder.Entity<Session>();
            //modelBuilder.Entity<Ticket>();
            //modelBuilder.Entity<FilmGenre>();
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
