using System.Collections.Generic;

namespace EFWEbApi.DTO
{
    public class EmployeeDTO
    {
        public string Name { get; set; }
        public bool Responsible { get; set; }
    }
    public class EmployeeDTOCount
    {
        public int Count { get; set; }
        public List<EmployeeDTO> EmployeeAndResponsible { get; set; }    
    }
}
