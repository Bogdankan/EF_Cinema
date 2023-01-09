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
        }
    }
}
