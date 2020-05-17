using Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Config
{
    public class GeolocalizationConfiguration : IEntityTypeConfiguration<Geolocalization>
    {
        public void Configure(EntityTypeBuilder<Geolocalization> builder)
        {
            builder.HasKey(geo => geo.Id);

            builder.Property(geo => geo.Latitude).IsRequired(true).HasColumnType("DECIMAL(3,2)");
            builder.Property(geo => geo.Longitude).IsRequired(true).HasColumnType("DECIMAL(3,2)");
        }
    }
}