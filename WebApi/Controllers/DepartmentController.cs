using Domain.Dtos;
using Domain.Entities;
using Infrastructre.Services;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class DeparmentController : ControllerBase
{
    private DeparmentService _deparmentService;
    public DeparmentController(DeparmentService deparmentService)
    {
        _deparmentService = deparmentService;
    }

    [HttpGet("Get")]
    public async Task<List<DeparmentDto>> Get()
    {
        return await _deparmentService.Get();
    }

    [HttpPost("Add")]
    public async Task<DeparmentDto> Add([FromBody] DeparmentDto deparmentDto)
    {
        return await  _deparmentService.Add(deparmentDto);
    }

    [HttpPut("Update ")]
    public async Task<DeparmentDto> Put([FromBody] DeparmentDto deparment) => await _deparmentService.Update(deparment);


    [HttpDelete("Delete")]
    public bool Delete(int id) => _deparmentService.Delete(id);
}
