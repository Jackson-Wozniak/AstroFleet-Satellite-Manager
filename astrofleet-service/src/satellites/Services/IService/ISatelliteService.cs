using astrofleet_service.satellites.Entities;

namespace astrofleet_service.satellites.Services.IService;

public interface ISatelliteService
{
    Task<Satellite> FindSatelliteById(string id);
    Task<List<Satellite>> FindSatellitesByFamily(string family);
    Task<List<Satellite>> FindAllSatellites();
}