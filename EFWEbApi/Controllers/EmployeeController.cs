using EFWEbApi.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service;
using System.Collections.Generic;

namespace EFWEbApi.Controllers
{
    [Route("employees")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        public List<EmployeeDTOCount> GetEmployeeCountAndList()
        {
            var count = new List<EmployeeDTOCount>();
            var employeeDTOS = new List<EmployeeDTO>();
            var instance = EmployeeService.Instance.GetEmployees();

            foreach (var employee in instance)
            {
                var employeeDTO = new EmployeeDTO()
                {
                    Name = employee.Name,
                    Responsible = employee.Departments.Count > 0
                };
                employeeDTOS.Add(employeeDTO);
            }
            count.Add
                (
                new EmployeeDTOCount
                {
                    Count = instance.Count,
                    EmployeeAndResponsible = employeeDTOS
                }) ;
            
            return count;
        }
    }
}
