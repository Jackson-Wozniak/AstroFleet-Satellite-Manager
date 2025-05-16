namespace astrofleet_service.satellites.Entities;

public class ScientificSatellite : Satellite
{
    public double TemperatureCelsius { get; set; }

    public ScientificSatellite() { }
    
    private ScientificSatellite(string familyCode, double elevation, double mass, DateTime start)
        : base(familyCode, elevation, mass, start)
    {
        TemperatureCelsius = 0.0;
    }
    
    public static Satellite TemperatureReaderSatellite(string familyCode, double elevation, double mass, DateTime start)
    {
        return new ScientificSatellite(familyCode, elevation, mass, start);
    }
}