using System.Collections.Generic;

namespace EFWEbApi.DTO
{
    public class DepartmentDTO
    {
        public string Name { get; set; }
        public List<EmailDTO> Emails { get; set; }
    }
}
