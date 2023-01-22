using Domain.Dtos;
using Domain.Entities;
using Infrastructre.Services;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class RegionController : ControllerBase
{
    private RegionService _regionsService;
    public RegionController(RegionService regionService)
    {
        _regionsService = regionService;
    }

    [HttpGet("Get")]
    public async Task<List<RegionDto>> Get()
    {
        return await _regionsService.GetRegions();
    }

   
    [HttpPost("Add")]
 
    public async Task< RegionDto> Add([FromBody] RegionDto regionDto)
    {
        return await _regionsService.AddRegion(regionDto);
    }

    [HttpPut("Update ")]
    public void Update(RegionDto region)
    {
         _regionsService.Update(region);
    }

    [HttpDelete("Delete")]
    public async Task< bool> Delete(int id) => await _regionsService.Delete(id);


}
