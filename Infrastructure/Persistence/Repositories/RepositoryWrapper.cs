using Application.Contracts.Infrastructure;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Repositories
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private readonly RepositoryContext _repoContext;
        private IEmployeeRepository _employee;
        private IOrganisationRepository _organisation;

        public IEmployeeRepository Employee
        {
            get
            {
                if (_employee == null)
                {
                    _employee = new EmployeeRepository(_repoContext);
                }
                return _employee;
            }
        }


        public IOrganisationRepository Organisation
        {
            get
            {
                if (_organisation == null)
                {
                    _organisation = new OrganisationRepository(_repoContext);
                }
                return _organisation;
            }
        }

        public RepositoryWrapper(RepositoryContext repositoryContext)
        {
            _repoContext = repositoryContext;
        }

        public async Task Save()
        {
            await _repoContext.SaveChangesAsync();
        }
    }
}
