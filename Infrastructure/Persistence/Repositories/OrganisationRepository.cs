using Application.Contracts.Infrastructure;
using Domain.Entities;

namespace Infrastructure.Persistence.Repositories
{
    public class OrganisationRepository : RepositoryBase<Organisation>, IOrganisationRepository
    {
        public OrganisationRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
