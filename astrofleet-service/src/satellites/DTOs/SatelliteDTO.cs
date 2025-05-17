using astrofleet_service.satellites.Entities;
using astrofleet_service.satellites.Enums;
using astrofleet_service.satellites.Utils;

namespace astrofleet_service.satellites.DTOs;

public class SatelliteDTO
{
    public string Name { get; set; }
    public double ElevationInKilometers { get; set; }
    public double MassInKilograms { get; set; }
    public string OrbitStartTime { get; set; }
    public string OrbitType { get; set; }
    public string HomePlanet { get; set; }

    public SatelliteDTO(Satellite satellite)
    {
        Name = satellite.Id;
        ElevationInKilometers = satellite.ElevationInKilometers;
        MassInKilograms = satellite.MassInKilograms;
        OrbitStartTime = satellite.OrbitStartTime.ToString("G");
        OrbitType = OrbitTypeUtils.ToString(satellite.OrbitType);
        HomePlanet = satellite.HomePlanet;
    }
}