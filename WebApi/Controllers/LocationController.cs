using Domain.Dtos;
using Domain.Entities;
using Infrastructre.Services;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class LocationController : ControllerBase
{
    private LocationService _locationService;
    public LocationController(LocationService locationService)
    {
        _locationService = locationService;
    }

    [HttpGet("Get")]
    public async Task<List<LocationDto>> Get()
    {
        return await _locationService.Get();
    }

    [HttpPost("Add")]

    public async Task <LocationDto> Add([FromBody] LocationDto locationDto)
    {
        return await _locationService.Add(locationDto);
    }

    [HttpPut("Update ")]
    public async Task<LocationDto> Put( LocationDto location) => await _locationService.Update(location);

    [HttpDelete("Delete")]
    public async Task<bool> Delete(int id) => await _locationService.Delete(id);


}
