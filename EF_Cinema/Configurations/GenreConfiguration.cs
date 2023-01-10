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
    internal class GenreConfiguration : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder.HasKey(g => g.Id);
            builder.Property(g => g.Name).IsRequired().HasMaxLength(50);
            builder.HasMany(g => g.Films).WithMany(f => f.Genres).UsingEntity<FilmGenre>();
            builder.HasMany(x => x.Films).WithMany(x => x.Genres).UsingEntity<FilmGenre>(
               j => j.HasOne(x => x.Film).WithMany(x => x.FilmGenres).HasForeignKey(x => x.FilmId),
               j => j.HasOne(x => x.Genre).WithMany(x => x.FilmGenres).HasForeignKey(x => x.GenreId),         
               j =>
               {
                   j.HasKey(k => new { k.FilmId, k.GenreId });
                   j.ToTable("FilmGenre");
               }
               );

            builder.HasData(new Genre {Id = 1, Name = "Fantasy"});
        }
    }
}
