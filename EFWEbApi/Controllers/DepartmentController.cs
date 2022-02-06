using EFWEbApi.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service;
using System.Collections.Generic;

namespace EFWEbApi.Controllers
{
    [Route("departments")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        [HttpGet]
        public List<DepartmentDTO> GetDepartmentAndResponsible()
        {
            var departmentDTOS = new List<DepartmentDTO>();
            foreach (var department in DepartmentService.Instance.GetDepartmentAndEmail())
            {
                var emailDTOS = new List<EmailDTO>();
                foreach (var email in department.Staff.Emails)
                {
                    var emailDTO = new EmailDTO()
                    {
                        Email = email.Email
                    };
                    emailDTOS.Add(emailDTO);
                }
                var departmentDTO = new DepartmentDTO()
                {
                    Name = department.Name,
                    Emails = emailDTOS
                };
                departmentDTOS.Add(departmentDTO);
            }
            return departmentDTOS;
        }
    }
}
