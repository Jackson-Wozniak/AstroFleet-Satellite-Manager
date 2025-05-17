using astrofleet_service.satellites.Enums;
using astrofleet_service.satellites.Utils;

namespace astrofleet_service.satellites.Entities;

public class Satellite
{
    public string Id { get; set; }
    public string FamilyCode { get; set; }
    public double ElevationInKilometers { get; set; }
    public double MassInKilograms { get; set; }
    public DateTime OrbitStartTime { get; set; }
    public OrbitType OrbitType { get; set; }
    public string HomePlanet { get; set; }
    
    public Satellite(){ }

    public Satellite(string familyCode, double elevation, double mass, DateTime start, string planet)
    {
        FamilyCode = familyCode;
        ElevationInKilometers = elevation;
        MassInKilograms = mass;
        OrbitStartTime = start;
        OrbitType = OrbitTypeUtils.FromElevation(elevation);
        HomePlanet = planet;
    }
}