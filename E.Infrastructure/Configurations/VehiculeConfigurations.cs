using E.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E.Infrastructure.Configurations
{
    internal class VehiculeConfigurations:IEntityTypeConfiguration<Vehicule>
    {
        public void Configure(EntityTypeBuilder<Vehicule> builder)
        {
            builder.HasMany(p => p.Reservations).
              WithOne(p => p.Vehicule)
             .HasForeignKey(fk => fk.Vehiculekey);

        }
    }
}