using astrofleet_service.satellites.Entities;
using Microsoft.EntityFrameworkCore;

namespace astrofleet_service.Data;

public partial class AstroFleetDbContext
{
    public DbSet<Satellite> Satellites { get; set; }
    
    partial void ConfigureSatelliteDb(ModelBuilder builder)
    {
        
    }
}