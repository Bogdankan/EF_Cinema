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
        public DbSet<Cinema> Cinema { get; set; } = null!;
        public DbSet<CinemasNetwork> CinemasNetwork { get; set; } = null!;        
        public DbSet<Country> Countrie { get; set; } = null!;
        public DbSet<Film> Film { get; set; } = null!;
        public DbSet<Genre> Genre { get; set; } = null!;
        public DbSet<Hall> Hall { get; set; } = null!;
        //public DbSet<Series> Serie { get; set; } = null!;
        public DbSet<Session> Session { get; set; } = null!;
        public DbSet<Ticket> Ticket { get; set; } = null!;
        public IQueryable<Country> FindCountries(string substring) => FromExpression(() => FindCountries(substring));
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
            modelBuilder.HasDbFunction (() => FindCountries(default));
        }
    }
}
