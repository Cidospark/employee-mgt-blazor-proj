using EmpMgt.Data.Entities;
using EmpMgt.Data.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace EmpMgt.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EmployeesController : ControllerBase
{
    private readonly IEmployeeRepository employeeRepository;

    public EmployeesController(IEmployeeRepository employeeRepository)
    {
        this.employeeRepository = employeeRepository;
    }

    [HttpGet]
    public async Task<ActionResult> GetEmployees()
    {
        try
        {
            return Ok(await employeeRepository.GetEmployees());
        }
        catch (Exception)
        {
            return StatusCode(StatusCodes.Status500InternalServerError,
                "Error retrieving data from the database");
        }
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<Employee>> GetEmployee(int id)
    {
        try
        {
            var result = await employeeRepository.GetEmployee(id);

            if (result == null) return NotFound();

            return result;
        }
        catch (Exception)
        {
            return StatusCode(StatusCodes.Status500InternalServerError,
                "Error retrieving data from the database");
        }
    }
}

