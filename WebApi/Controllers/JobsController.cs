using Domain.Dtos;
using Domain.Entities;
using Infrastructre.Services;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class JobController : ControllerBase
{
    private JobService _jobService;
    public JobController(JobService jobService)
    {
        _jobService = jobService;
    }

    [HttpGet("Get")]
    public async  Task<List<JobDto>> Get()
    {
        return await _jobService.Get();
    }


    [HttpPost("Add")]

    public async Task <JobDto> Add([FromBody] JobDto locationDto)
    {
        return await _jobService.Add(locationDto);
    }

    [HttpPut("Update ")]
    public async Task <JobDto> Put([FromBody] JobDto location) => await _jobService.Update(location);

    [HttpDelete("Delete")]
    public bool Delete(int id) => _jobService.Delete(id);


}
