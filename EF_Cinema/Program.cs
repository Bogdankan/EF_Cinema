using EF_Cinema;
using EF_Cinema.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
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

    //CinemasNetwork cinemasNetwork1 = new CinemasNetwork { Name = "Multiplex" };
    //CinemasNetwork cinemasNetwork2 = new CinemasNetwork { Name = "Liniya Kino" };
    //CinemasNetwork cinemasNetwork3 = new CinemasNetwork { Name = "Outlet" };

    //db.CinemasNetworks.AddRange(cinemasNetwork1, cinemasNetwork2, cinemasNetwork3);
    //db.SaveChanges();

    //Cinema cinema1 = new Cinema { Sity = "Kyiv", CinemasNetworkId = cinemasNetwork1.Id };
    //Cinema cinema2 = new Cinema { Sity = "Lviv", CinemasNetworkId = cinemasNetwork3.Id };
    //Cinema cinema3 = new Cinema { Sity = "Kharkiv", CinemasNetworkId = cinemasNetwork2.Id };
    //Cinema cinema4 = new Cinema { Sity = "Odesa", CinemasNetworkId = cinemasNetwork2.Id };

    //db.Cinemas.AddRange(cinema1, cinema2, cinema3, cinema4);
    //db.SaveChanges();


    //foreach (var cinema in db.Cinemas.ToList())
    //{
    //    Console.WriteLine($"{cinema.CinemasNetwork?.Name} is located in {cinema.Sity}");
    //}


    //TPH

    //Film film1 = new Film { Name = "Star Wars", Duration = DateTime.Now, CountryId = 1 };
    //Film film2 = new Film { Name = "Pulp Fiction", Duration =DateTime.Now, CountryId = 1 };

    //db.Films.Add(film1);
    //db.Films.Add(film2);

    //Series series1 = new Series { Name = "Breaking Bad", Duration = DateTime.Now, EpisodeCount = 62, SeasonsCount = 5, CountryId = 1 };
    //Series series2 = new Series { Name = "Prison Break", Duration =DateTime.Now, EpisodeCount = 90, SeasonsCount = 5, CountryId = 1 };

    //db.Films.Add(series1);
    //db.Films.Add(series2);

    //db.SaveChanges();

    //var films = db.Films.ToList();
    //Console.WriteLine("All films:");
    //foreach (var film in films)
    //{
    //    Console.WriteLine(film.Name);
    //}

    //var series = db.Series.ToList();
    //Console.WriteLine("All series:");
    //foreach (var serie in series)
    //{
    //    Console.WriteLine(serie.Name);
    //}

    //TPT

    //Film film1 = new Film { Name = "Star Wars", Duration = DateTime.Now, CountryId = 1 };
    //Film film2 = new Film { Name = "Pulp Fiction", Duration = DateTime.Now, CountryId = 1 };

    //db.Films.Add(film1);
    //db.Films.Add(film2);

    //Series series1 = new Series { Name = "Breaking Bad", Duration = DateTime.Now, EpisodeCount = 62, SeasonsCount = 5, CountryId = 1 };
    //Series series2 = new Series { Name = "Prison Break", Duration = DateTime.Now, EpisodeCount = 90, SeasonsCount = 5, CountryId = 1 };

    //db.Films.Add(series1);
    //db.Films.Add(series2);

    //db.SaveChanges();

    //var films = db.Films.ToList();
    //Console.WriteLine("All films:");
    //foreach (var film in films)
    //{
    //    Console.WriteLine(film.Name);
    //}

    //var series = db.Series.ToList();
    //Console.WriteLine("All series:");
    //foreach (var serie in series)
    //{
    //    Console.WriteLine(serie.Name);
    //}
}


//Create
using (CinemaContext db = new CinemaContext(options))
{
    var film1 = new Film { Name = "Star Wars", Duration = DateTime.Now, CountryId = 1 };
    var film2 = new Film { Name = "Pulp Fiction", Duration = DateTime.Now, CountryId = 1 };

    db.Films.Add(film1);
    db.Films.Add(film2);
    db.SaveChanges();

    var films = db.Films.ToList();

    Console.WriteLine("Added films:");
    foreach (var film in films)
    {
        Console.WriteLine(film.Name);
    }
}

//Alter
using (CinemaContext db = new CinemaContext(options))
{
    var film = db.Films.FirstOrDefault(x => x.Name == "Pulp Fiction");

    Console.WriteLine($"Old duration: {film.Duration}");

    film.Duration = DateTime.MaxValue;
    db.SaveChanges();

    var films = db.Films.ToList();

    Console.WriteLine("Films after altering:");
    foreach (var f in films)
    {
        Console.WriteLine($"{f.Name} ||| {f.Duration}");
    }
}

//Delete
using (CinemaContext db = new CinemaContext(options))
{
    var film = db.Films.FirstOrDefault();

    if (film != null)
    {
        db.Films.Remove(film);
        db.SaveChanges();
    }

    var films = db.Films.ToList();

    Console.WriteLine("Films after deleting:");
    foreach (var f in films)
    {
        Console.WriteLine($"{f.Name}");
    }
}
