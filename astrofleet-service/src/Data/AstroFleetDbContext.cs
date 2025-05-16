using Microsoft.EntityFrameworkCore;

namespace astrofleet_service.Data;

public partial class AstroFleetDbContext : DbContext
{
    partial void ConfigureSatelliteDb(ModelBuilder builder);
    
    public AstroFleetDbContext(DbContextOptions<AstroFleetDbContext> options): base(options) { }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        ConfigureSatelliteDb(builder);
    }
}