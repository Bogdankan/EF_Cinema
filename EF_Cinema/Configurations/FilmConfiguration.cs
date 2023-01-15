using EF_Cinema.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Cinema.Configurations
{
    internal class FilmConfiguration : IEntityTypeConfiguration<Film>
    {  
        public void Configure(EntityTypeBuilder<Film> builder)
        {
            builder.Property(f => f.Name).IsRequired().HasMaxLength(50);
            //builder.HasOne(f => f.Country).WithMany(c => c.Films).HasForeignKey(f => f.CountryId);
            builder.HasMany(f => f.Sessions).WithOne(c => c.Film).HasForeignKey(f => f.FilmId);
            builder.HasMany(x => x.Genres).WithMany(x => x.Films).UsingEntity<FilmGenre>(
                j => j.HasOne(x => x.Genre).WithMany(x => x.FilmGenres).HasForeignKey(x => x.GenreId),
                j => j.HasOne(x => x.Film).WithMany(x => x.FilmGenres).HasForeignKey(x => x.FilmId),
                j =>
                {
                    j.HasKey(k => new { k.FilmId, k.GenreId });
                    j.ToTable("FilmGenre");
                }
                );

            //builder.HasData(new Film { Name = "Star Wars", CountryId = 1, SessionId = 1, GenreId = 1, Duration = new DateTime(0, 0, 0, 2, 15, 56) });
        }
    }
}
