using EF_Cinema;
using EF_Cinema.Models;
using Microsoft.Data.SqlClient;
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
var options = optionsBuilder.UseLazyLoadingProxies().UseSqlServer(connectionString).Options;

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
//using (CinemaContext db = new CinemaContext(options))
//{
//    var film1 = new Film { Name = "Star Wars", Duration = DateTime.Now, CountryId = 1 };
//    var film2 = new Film { Name = "Pulp Fiction", Duration = DateTime.Now, CountryId = 1 };

//    db.Films.Add(film1);
//    db.Films.Add(film2);
//    db.SaveChanges();

//    var films = db.Films.ToList();

//    Console.WriteLine("Added films:");
//    foreach (var film in films)
//    {
//        Console.WriteLine(film.Name);
//    }
//}

////Alter
//using (CinemaContext db = new CinemaContext(options))
//{
//    var film = db.Films.FirstOrDefault(x => x.Name == "Pulp Fiction");

//    Console.WriteLine($"Old duration: {film.Duration}");

//    film.Duration = DateTime.MaxValue;
//    db.SaveChanges();

//    var films = db.Films.ToList();

//    Console.WriteLine("Films after altering:");
//    foreach (var f in films)
//    {
//        Console.WriteLine($"{f.Name} ||| {f.Duration}");
//    }
//}

////Delete
//using (CinemaContext db = new CinemaContext(options))
//{
//    var film = db.Films.FirstOrDefault();

//    if (film != null)
//    {
//        db.Films.Remove(film);
//        db.SaveChanges();
//    }

//    var films = db.Films.ToList();

//    Console.WriteLine("Films after deleting:");
//    foreach (var f in films)
//    {
//        Console.WriteLine($"{f.Name}");
//    }
//}


//LINQ to entities

//Cinema cinema11 = new Cinema() { CinemasNetworkId = 1, Sity = "Kharkiv", Street = "Street11", House = "H13" };

#region Lab3
//using (CinemaContext db = new CinemaContext(options))
//{
//    //Initialization
//    //CinemasNetwork cinemasNetwork1 = new CinemasNetwork { Name = "Multiplex" };
//    //CinemasNetwork cinemasNetwork2 = new CinemasNetwork { Name = "Linia Kino" };
//    //CinemasNetwork cinemasNetwork3 = new CinemasNetwork { Name = "Outlet" };

//    //db.CinemasNetwork.AddRange(cinemasNetwork1, cinemasNetwork2, cinemasNetwork3);

//    //Cinema cinema1 = new Cinema { CinemasNetwork = cinemasNetwork1, Sity = "Kyiv", Street = "Street1", House = "H1" };
//    //Cinema cinema2 = new Cinema { CinemasNetwork = cinemasNetwork3, Sity = "Dnipro", Street = "Street2", House = "H2" };
//    //Cinema cinema3 = new Cinema { CinemasNetwork = cinemasNetwork2, Sity = "Kharkiv", Street = "Street3", House = "H11" };
//    //Cinema cinema4 = new Cinema { CinemasNetwork = cinemasNetwork2, Sity = "Kharkiv", Street = "Street4", House = "H134" };
//    //Cinema cinema5 = new Cinema { CinemasNetwork = cinemasNetwork1, Sity = "Odesa", Street = "Street5", House = "H6" };
//    //Cinema cinema6 = new Cinema { CinemasNetwork = cinemasNetwork1, Sity = "Kyiv", Street = "Street6", House = "H8" };

//    //db.Cinema.AddRange(cinema1, cinema2, cinema3, cinema4, cinema5, cinema6);

//    //Hall hall1 = new Hall { Cinema = cinema2 };
//    //Hall hall2 = new Hall { Cinema = cinema4 };
//    //Hall hall3 = new Hall { Cinema = cinema1 };
//    //Hall hall4 = new Hall { Cinema = cinema3 };
//    //Hall hall5 = new Hall { Cinema = cinema6 };
//    //Hall hall6 = new Hall { Cinema = cinema1 };

//    //db.Hall.AddRange(hall1, hall2, hall3, hall4, hall5, hall6);

//    Film film1 = new Film { Name = "Fight club", CountryId = 1, GenreId = 1 };
//    Film film2 = new Film { Name = "Interstellar", CountryId = 1, GenreId = 1 };
//    Film film3 = new Film { Name = "Shawshank redemption", CountryId = 1, GenreId = 1 };

//    db.Film.AddRange(film1, film2, film3);

//    db.SaveChanges();

//    //Union
//    var cinemas = db.Cinema
//        .Where(c => c.Id > 3)
//        .Union(db.Cinema.Where(c => c.CinemasNetworkId == 3));

//    foreach (var c in cinemas)
//    {
//        Console.WriteLine($"{c.Id} || {c.CinemasNetworkId}");
//    }
//    Console.WriteLine();

//    //Intersect
//    var cinemas1 = db.Cinema
//        .Where(c => c.Id > 3)
//        .Intersect(db.Cinema.Where(c => c.CinemasNetworkId == 1));

//    foreach (var c in cinemas1)
//    {
//        Console.WriteLine($"{c.Id} || {c.CinemasNetworkId}");
//    }
//    Console.WriteLine();

//    //Except
//    var cinemas2 = db.Cinema
//       .Where(c => c.Id > 3)
//       .Except(db.Cinema.Where(c => c.CinemasNetworkId == 1));

//    foreach (var c in cinemas2)
//    {
//        Console.WriteLine($"{c.Id} || {c.CinemasNetworkId}");
//    }
//    Console.WriteLine();

//    //Join
//    var cinemas3 = db.Cinema
//        .Join(db.CinemasNetwork, c => c.CinemasNetworkId,
//        cn => cn.Id,
//        (c, cn) => new
//        {
//            Sity = c.Sity,
//            Street = c.Street,
//            House = c.House,
//            CinemasNetwork = cn.Name
//        });

//    foreach (var c in cinemas3)
//    {
//        Console.WriteLine($"{c.CinemasNetwork}: {c.Sity}, {c.Street}, {c.House}");
//    }
//    Console.WriteLine();

//    //Distinct
//    var cinemas4 = db.Cinema
//        .Select(c => c.Sity)
//        .Distinct()
//        .ToList();

//    foreach (var c in cinemas4)
//    {
//        Console.WriteLine($"{c}");
//    }
//    Console.WriteLine();

//    //Group by
//    var cinemas5 = db.Cinema
//        .GroupBy(c => c.Sity)
//        .Select(g => new { g.Key, Count = g.Count()})
//        .ToList();

//    foreach (var c in cinemas5)
//    {
//        Console.WriteLine($"{c.Key} || {c.Count}");
//    }
//    Console.WriteLine();

//    //Agregate func: Count
//    var cinemas6 = db.Cinema
//       .Count();
//    var cinemas7 = db.Cinema
//      .Count(c => c.Sity.Contains("Kyiv"));

//    Console.WriteLine($"{cinemas6}");
//    Console.WriteLine($"{cinemas7}");

//    Console.WriteLine();

//    //Eager loading
//    var cinemas8 = db.Cinema
//        .Include(c => c.CinemasNetwork)
//        .ToList();

//    foreach (var c in cinemas8)
//    {
//        Console.WriteLine($"{c.Id} || {c.CinemasNetwork.Name}");
//    }
//    Console.WriteLine();

//    //Explicit loading
//    var cinemasNetwork = db.CinemasNetwork.FirstOrDefault();

//    if (cinemasNetwork != null)
//    {
//        db.Cinema.Where(c => c.CinemasNetworkId == cinemasNetwork.Id).Load();
//    }

//    Console.WriteLine($"Cinemas Network: {cinemasNetwork!.Name}");
//    foreach (var c in db.Cinema)
//        Console.WriteLine($"\tCinema: {c.Sity}");
//    Console.WriteLine();

//    //Lazy loading
//    var cinemas9 = db.Cinema.FirstOrDefault();
//    foreach (var c in db.Cinema)
//        Console.WriteLine($"{c.CinemasNetwork.Name} || {c.Sity}");
//    Console.WriteLine();

//    //Untracked data
//    Console.WriteLine($"cinema11 state={db.Entry(cinema11).State}");
//    db.Attach(cinema11);
//    Console.WriteLine($"cinema11 state={db.Entry(cinema11).State}");
//    db.Cinema.Add(cinema11);
//    db.SaveChanges();
//    cinema11.Street = "H12";
//    db.ChangeTracker.DetectChanges();
//    Console.WriteLine($"cinema11 state={db.Entry(cinema11).State}");
//    Console.WriteLine();

//    //Stored func and procedures
//    SqlParameter param = new SqlParameter("@substring", "U");
//    var countries = db.Countrie.FromSqlRaw("SELECT * FROM dbo.FindCountries('U')", param).ToList();
//    foreach (var c in countries)
//        Console.WriteLine($"Country: {c.Name}");

//    //Проецирование хранимой функции на метод класса
//    var countries2 = db.FindCountries("U");
//    foreach (var c in countries)
//        Console.WriteLine($"Country: {c.Name}");
//    Console.WriteLine();

//    SqlParameter param1 = new SqlParameter("@name", "Multiplex");
//    var cinemas13 = db.Cinema.FromSqlRaw("EXEC GetCinemasByCinemasNetwork @name", param1).ToList();
//    foreach (var p in cinemas13)
//        Console.WriteLine($"{p.CinemasNetwork.Name} - {p.Sity}");
//    Console.ReadKey();

//}
#endregion

using (CinemaContext db = new CinemaContext(options))
{
    //var film = db.Film.FirstOrDefault();

    //if (film != null)
    //{
    //    db.Film.Remove(film);
    //    db.SaveChanges();
    //}

    var cinema = new Cinema { CinemasNetworkId = 1, Sity = "Kyiv", Street = "Street1", House = "12B" };

    db.Cinema.Add(cinema);
    db.SaveChanges();

    var cinemas = db.Cinema.ToList();

    //Console.WriteLine("Added cinemas:");
    //foreach (var film in cinemas)
    //{
    //    Console.WriteLine(film.Sity);
    //}

    var cinemaid = db.Cinema!.ToList().FirstOrDefault().Id;

    for (int i = 0; i < 10; i++)
    {
        var hall = new Hall { CinemaId = cinemaid };
        db.Hall.Add(hall);
        db.SaveChanges();
    }

    var genreid = db.Cinema!.ToList().FirstOrDefault().Id;

    for (int i = 0; i < 5; i++)
    {
        var film = new Film { Name = "Film" + (i + 1).ToString(), GenreId = genreid, Duration = DateTime.Now };
        db.Film.Add(film);
        db.SaveChanges();
    }

    Random random = new Random();

    for (int i = 2053; i < 2058; i++) //FilmId from 2053 to 2058
    {
        for (int j = 0; j < 4; j++)
        {
            var hallid = random.Next(1002, 1011);
            var day = random.Next(1, 31);
            var session = new Session { FilmId = i, HallId = hallid, DateTime = new DateTime(2022, 12, day, 1 + j, 0, 0) };
            db.Session.Add(session);
            db.SaveChanges();
        }
    }

    var sessions = db.Session.ToList();

    Console.WriteLine("Added sessions:");
    foreach (var session in sessions)
    {
        Console.WriteLine(session.DateTime.DayOfWeek);
    }

    for (int i = 1; i < 20; i++)
    {
        var place = random.Next(1, 31);
        var row = random.Next(1, 12);
        var price = random.Next(501, 1999);
        var ticket = new Ticket { HallNumber = 1, PlaceNumber = place, RowNumber = row, SessionId = i, Price = price };
        db.Ticket.Add(ticket);
        db.SaveChanges();
    }

    //Query
    //var films = db.Film
    //    .Select();
}

//DateTime date = new DateTime(2023, 12, 7, 12, 0, 0);

//Console.WriteLine(date.DayOfWeek);

