using astrofleet_service.satellites.DTOs;
using astrofleet_service.satellites.Services;
using astrofleet_service.satellites.Services.IService;
using Microsoft.AspNetCore.Mvc;

namespace astrofleet_service.satellites.Controllers;

[Route("/api/Satellites")]
[ApiController]
public class SatelliteController : ControllerBase
{
    private readonly ISatelliteService _satelliteService;

    public SatelliteController(ISatelliteService satelliteService)
    {
        _satelliteService = satelliteService;
    }

    [HttpGet]
    public ActionResult<List<SatelliteDTO>> GetAllSatellites()
    {
        return Ok(_satelliteService.FindAllSatellites());
    }
    
    [HttpGet("/{name}")]
    public ActionResult<SatelliteDTO> GetSatellite(string name)
    {
        return Ok(_satelliteService.FindSatelliteById(name));
    }
    
    [HttpGet("/family/{family}")]
    public ActionResult<List<SatelliteDTO>> GetSatellitesByFamily(string family)
    {
        return Ok(_satelliteService.FindSatellitesByFamily(family));
    }
}