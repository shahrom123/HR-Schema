using Domain.Dtos;
using Domain.Entities;
using Infrastructre.Services;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class EmployeeController : ControllerBase
{
    private EmployeeService _employeeService;
    public EmployeeController(EmployeeService employeeService)
    {
        _employeeService = employeeService;
    }

    [HttpGet("Get")]
    public async Task<List<EmployeeDto>> Get()
    {
        return await _employeeService.Get();
    }

    [HttpPost("Add")]
    public async Task<EmployeeDto> Add([FromBody] EmployeeDto employeeDto)
    {
        var e = await _employeeService.Add(employeeDto);
        return e;
    }

    [HttpPut("Update ")]
    public async Task<EmployeeDto> Put([FromBody] EmployeeDto employee) => await _employeeService.Update(employee);


    [HttpDelete("Delete")]
    public bool Delete(int id) => _employeeService.Delete(id);
}
