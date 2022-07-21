using System.Threading.Tasks;

namespace Application.Contracts.Infrastructure
{
    public interface IRepositoryWrapper
    {
        IEmployeeRepository Employee { get; }
        IOrganisationRepository Organisation { get; }
        Task Save();
    }
}
