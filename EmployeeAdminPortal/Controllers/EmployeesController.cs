using EmployeeAdminPortal.Data;
using EmployeeAdminPortal.Models;
using EmployeeAdminPortal.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeAdminPortal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;
        public EmployeesController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetEmployees()
        {
            return Ok(dbContext.Employees.ToList());
        }

        [HttpGet]
        [Route("{id:guid}")]
        public IActionResult GetEmployeeById(Guid id)
        {
            var employee = dbContext.Employees.Find(id);
            if (employee == null)
            {
                return NotFound();
            }
            return Ok(employee);
        }

        [HttpPost]
        public IActionResult AddEmployee(AddEmployeeDto addEmployeeDto)
        {
            var employeeEntity = new Employee()
            {
                Name = addEmployeeDto.Name,
                Email = addEmployeeDto.Email,
                Phone = addEmployeeDto.Phone,
                Salary = addEmployeeDto.Salary
            };

            dbContext.Employees.Add(employeeEntity);
            dbContext.SaveChanges();
            return Ok();
        }

        [HttpPut]
        [Route("{id:guid}")]
        public IActionResult UpdateEmployee(Guid id, AddEmployeeDto addEmployeeDto)
        {
            var employeeEntity = dbContext.Employees.Find(id);
            if (employeeEntity == null)
            {
                return NotFound();
            }
            employeeEntity.Name = addEmployeeDto.Name;
            employeeEntity.Email = addEmployeeDto.Email;
            employeeEntity.Phone = addEmployeeDto.Phone;
            employeeEntity.Salary = addEmployeeDto.Salary;
            dbContext.SaveChanges();
            return Ok();
        }

        [HttpDelete]
        [Route("{id:guid}")]
        public IActionResult DeleteEmployee(Guid id)
        {
            var employeeEntity = dbContext.Employees.Find(id);
            if (employeeEntity == null)
            {
                return NotFound();
            }
            dbContext.Employees.Remove(employeeEntity);
            dbContext.SaveChanges();
            return Ok();
        }
    }
}
