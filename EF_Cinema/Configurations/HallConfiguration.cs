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
    internal class HallConfiguration : IEntityTypeConfiguration<Hall>
    {
        public void Configure(EntityTypeBuilder<Hall> builder)
        {
            builder.HasKey(h => h.Id);
            builder.HasOne(h => h.Info).WithOne(i => i.Hall).HasForeignKey<HallInfo>(i => i.HallId);
            builder.HasOne(h => h.Cinema).WithMany(c => c.Halls).HasForeignKey(h => h.CinemaId);
            builder.HasMany(h => h.Sessions).WithOne(s => s.Hall).HasForeignKey(h=> h.HallId);
        }        
    }
}
