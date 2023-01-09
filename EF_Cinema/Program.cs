using EF_Cinema;
using EF_Cinema.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.ComponentModel.DataAnnotations;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;


var builder = new ConfigurationBuilder();

builder.SetBasePath(Directory.GetCurrentDirectory());

builder.AddJsonFile("appsettings.json");

var config = builder.Build();

string connectionString = config.GetConnectionString("DefaultConnection");

var optionsBuilder = new DbContextOptionsBuilder<CinemaContext>();
var options = optionsBuilder.UseSqlServer(connectionString).Options;

using (CinemaContext db = new CinemaContext(options))
{
    
    CinemasNetwork cinemasNetwork1 = new CinemasNetwork { Name = "Multiplex" };
    CinemasNetwork cinemasNetwork2 = new CinemasNetwork { Name = "Liniya Kino" };
    CinemasNetwork cinemasNetwork3 = new CinemasNetwork { Name = "Outlet" };
    Cinema cinema1 = new Cinema { Sity = "Kyiv", CinemasNetwork = cinemasNetwork1 };
    Cinema cinema2 = new Cinema { Sity = "Lviv", CinemasNetwork = cinemasNetwork3 };
    Cinema cinema3 = new Cinema { Sity = "Kharkiv", CinemasNetwork = cinemasNetwork2 };
    Cinema cinema4 = new Cinema { Sity = "Odesa", CinemasNetwork = cinemasNetwork2 };

    db.Cinemas.AddRange(cinema1, cinema2, cinema3, cinema4);  // добавление компаний
    db.CinemasNetworks.AddRange(cinemasNetwork1, cinemasNetwork2, cinemasNetwork3);     // добавление пользователей
    db.SaveChanges();

    foreach (var cinema in db.Cinemas.ToList())
    {
        Console.WriteLine($"{cinema.CinemasNetwork?.Name} is located in {cinema.Sity}");
    }
}
