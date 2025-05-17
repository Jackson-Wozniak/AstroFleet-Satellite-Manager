using astrofleet_service.satellites.Enums;

namespace astrofleet_service.satellites.Utils;

public class OrbitTypeUtils
{
    public static OrbitType FromElevation(double elevationInKilometers)
    {
        return elevationInKilometers switch
        {
            <= 2000 => OrbitType.LOW_EARTH_ORBIT, 
            <= 36000 => OrbitType.MEDIUM_EARTH_ORBIT,
            _ => OrbitType.GEOSTATIONARY_ORBIT
        };
    }

    public static string ToString(OrbitType type)
    {
        return type.ToString().ToUpper() switch
        {
            "LOW_EARTH_ORBIT" => "Low Earth Orbit",
            "MEDIUM_EARTH_ORBIT" => "Medium Earth Orbit",
            "GEOSTATIONARY_ORBIT" => "Geostationary Orbit"
        };
    }
}