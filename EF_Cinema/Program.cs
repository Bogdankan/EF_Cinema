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

    db.CinemasNetworks.AddRange(cinemasNetwork1, cinemasNetwork2, cinemasNetwork3);
    db.SaveChanges();

    Cinema cinema1 = new Cinema { Sity = "Kyiv", CinemasNetworkId = cinemasNetwork1.Id };
    Cinema cinema2 = new Cinema { Sity = "Lviv", CinemasNetworkId = cinemasNetwork3.Id };
    Cinema cinema3 = new Cinema { Sity = "Kharkiv", CinemasNetworkId = cinemasNetwork2.Id };
    Cinema cinema4 = new Cinema { Sity = "Odesa", CinemasNetworkId = cinemasNetwork2.Id };

    db.Cinemas.AddRange(cinema1, cinema2, cinema3, cinema4);
    db.SaveChanges();


    foreach (var cinema in db.Cinemas.ToList())
    {
        Console.WriteLine($"{cinema.CinemasNetwork?.Name} is located in {cinema.Sity}");
    }
}
