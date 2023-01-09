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
    internal class CinemasNetworkConfiguration : IEntityTypeConfiguration<CinemasNetwork>
    {
        public void Configure(EntityTypeBuilder<CinemasNetwork> builder)
        {
            builder.Property(cn => cn.Name).IsRequired().HasMaxLength(50);
        }
    }
}
