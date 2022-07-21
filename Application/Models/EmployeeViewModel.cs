using System;

namespace Application.Models
{
    public class EmployeeViewModel
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string OrganisationNumber { get; set; }
    }
}
