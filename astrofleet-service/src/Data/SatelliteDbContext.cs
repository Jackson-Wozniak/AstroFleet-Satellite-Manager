using astrofleet_service.satellites.Entities;
using Microsoft.EntityFrameworkCore;

namespace astrofleet_service.Data;

public partial class AstroFleetDbContext
{
    public DbSet<ScientificSatellite> ScientificSatellites { get; set; }
    
    partial void ConfigureSatelliteDb(ModelBuilder builder)
    {
        builder.Entity<Satellite>()
            .HasDiscriminator<string>("SatelliteType")
            .HasValue<ScientificSatellite>("Scientific");
    }
}