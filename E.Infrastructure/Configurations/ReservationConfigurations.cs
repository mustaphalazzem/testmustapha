using E.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E.Infrastructure.Configurations
{
    internal class ReservationConfigurations : IEntityTypeConfiguration<Reservation>
    {
        public void Configure(EntityTypeBuilder<Reservation> builder)
        {
            builder.HasOne(p => p.Vehicule).
              WithMany(p => p.Reservations);
            builder.HasOne(p => p.Locataire).
              WithMany(p => p.Reservations);
            builder.HasKey(p => new { p.LocataireKey, p.Vehiculekey, p.DateReservation });


        }
    }
}
