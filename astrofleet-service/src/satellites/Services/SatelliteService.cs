using astrofleet_service.Data;
using astrofleet_service.satellites.Entities;
using astrofleet_service.satellites.Services.IService;
using Microsoft.EntityFrameworkCore;

namespace astrofleet_service.satellites.Services;

public class SatelliteService : ISatelliteService
{
    private readonly AstroFleetDbContext _astroFleetDbContext;

    public SatelliteService(AstroFleetDbContext dbContext)
    {
        _astroFleetDbContext = dbContext;
    }

    public async Task<Satellite> FindSatelliteById(string id)
    {
        return await _astroFleetDbContext.Satellites.FirstOrDefaultAsync(s => s.Id == id) 
               ?? throw new Exception();
    }

    public async Task<List<Satellite>> FindSatellitesByFamily(string family)
    {
        return await _astroFleetDbContext.Satellites
            .Where(s => s.FamilyCode.Equals(family)).ToListAsync();
    }

    public async Task<List<Satellite>> FindAllSatellites()
    {
        return await _astroFleetDbContext.Satellites.ToListAsync();
    }
}