using Domain.Dtos;
using Domain.Entities;
using Infrastructre.Services;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class CountryController : ControllerBase
{
    private CountryService _countryService;
    public CountryController(CountryService jobService)
    {
        _countryService = jobService;
    }

    [HttpGet("Get")]
    public async Task<List<CountryDto>> Get()
    {
        return await _countryService.Get();
    }

    [HttpPost("Add")]
    public async Task<CountryDto> Add([FromBody] CountryDto locationDto)
    {
        return await _countryService.Add(locationDto);
    }

    [HttpPut("Update ")]
    public async Task< CountryDto> Put([FromBody] CountryDto location) => await _countryService.Update(location);


    [HttpDelete("Delete")]
    public async Task< bool> Delete(int id) => await _countryService.Delete(id);
}
