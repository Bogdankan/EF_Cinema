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
    public class CinemaConfiguration : IEntityTypeConfiguration<Cinema>
    {
        public void Configure(EntityTypeBuilder<Cinema> builder)
        {
            builder.Property(c => c.Sity).IsRequired().HasMaxLength(50);
            builder.Property(c => c.Street).IsRequired().HasMaxLength(50);
            builder.Property(c => c.House).IsRequired().HasMaxLength(5);
        }
    }
}
