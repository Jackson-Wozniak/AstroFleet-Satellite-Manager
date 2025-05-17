using System.ComponentModel;

namespace astrofleet_service.satellites.Enums;

public enum OrbitType
{
    [Description("Low Earth Orbit")]
    LOW_EARTH_ORBIT,
    [Description("Medium Earth Orbit")]
    MEDIUM_EARTH_ORBIT,
    [Description("Geostationary Orbit")]
    GEOSTATIONARY_ORBIT
}