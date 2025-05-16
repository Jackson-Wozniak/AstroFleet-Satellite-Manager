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
}