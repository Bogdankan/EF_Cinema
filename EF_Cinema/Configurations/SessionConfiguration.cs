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
    internal class SessionConfiguration : IEntityTypeConfiguration<Session>
    {
        public void Configure(EntityTypeBuilder<Session> builder)
        {
            builder.Property(s => s.DateTime).HasDefaultValue(DateTime.Now);
            builder.HasOne(s => s.Film).WithMany(f => f.Sessions).HasForeignKey(s => s.FilmId);
            builder.HasMany(s => s.Tickets).WithOne(t => t.Session).HasForeignKey(s => s.SessionId);
            builder.HasOne(s => s.Hall).WithMany(h => h.Sessions).HasForeignKey(s => s.HallId);

            //builder.HasData(new Session { FilmId = 1, HallId = 1 });
        }
    }
}
