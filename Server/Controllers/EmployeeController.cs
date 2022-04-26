using Microsoft.AspNetCore.Mvc;
using MyEmployees.Server.Models;

namespace MyEmployees.Server.Controllers
{
    [Route("api/{controller}")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        static List<Employee> employees = new List<Employee>
        {
            new Employee {id = 1, firstname = "Sindre", lastname = "Sagdalen", jobrole = "Backend developer", department = "Application development"},
            new Employee {id = 2, firstname = "Henrik", lastname = "Sagdalen", jobrole = "Security analyst", department = "Security analytics"},
            new Employee {id = 3, firstname = "Thomas", lastname = "Nygaard", jobrole = "Tech lead", department = "Application development"},
            new Employee {id = 4, firstname = "Line", lastname = "Skjelbred", jobrole = "Database developer", department = "Database"},
            new Employee {id = 5, firstname = "Fredrik", lastname = "Thomassen", jobrole = "Frontend developer", department = "Application development"},
            new Employee {id = 6, firstname = "Ellen", lastname = "Jonsen", jobrole = "Frontend developer", department = "Application development"},
            new Employee {id = 7, firstname = "Daniel", lastname = "Alsgaard", jobrole = "Backend developer", department = "Application development"},
            new Employee {id = 8, firstname = "Pernille", lastname = "Pettersen", jobrole = "Data analyst", department = "Data analytics"},
            new Employee {id = 9, firstname = "David", lastname = "Johansen", jobrole = "Database Developer", department = "Database"},
            new Employee {id = 10, firstname = "Lise", lastname = "Fredriksen", jobrole = "Marketing consultant", department = "Public Relations"},
        };

        [HttpGet("/employees")]
        public async Task<IActionResult> GetEmployees()
        {
            return Ok(employees);
        }

        [HttpGet("/employee/{id}")]
        public async Task<IActionResult> GetEmployee(int id)
        {
            //id -= 1;
            return Ok(employees[id]);
        }

        /* public async Task<ActionResult<Employee>> UpdateEmployee(Employee employee)
         {
             try
             {
                 var employeeToUpdate = await GetEmployee(employee.id);

                 if (employeeToUpdate == null)
                 {
                     return NotFound($"Employee with Id = {employee.id} not found");
                 }
                 employeeToUpdate = employee;
                 return await;
             }
             catch (Exception)
             {
                 return StatusCode(StatusCodes.Status500InternalServerError,
                     "Error updating data");
             }
         }*/

    }
}
