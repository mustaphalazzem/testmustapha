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
    public class LocataireConfigurations : IEntityTypeConfiguration<Locataire>
    {
        public void Configure(EntityTypeBuilder<Locataire> builder)
        {
            builder.HasMany(p => p.Reservations).
              WithOne(p => p.Locataire)
             .HasForeignKey(fk => fk.LocataireKey);
          
        }
    }
}
