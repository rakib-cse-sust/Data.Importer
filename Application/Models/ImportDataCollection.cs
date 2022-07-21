using System.Collections.Generic;

namespace Application.Models
{
    public class ImportDataCollection
    {
        public ImportDataCollection()
        {
            Employees = new List<EmployeeViewModel>();
            Organisations = new List<OrganisationViewModel>();
        }

        public List<EmployeeViewModel> Employees { get; set; }
        public List<OrganisationViewModel> Organisations { get; set; }
    }
}
