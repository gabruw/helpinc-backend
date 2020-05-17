using Domain.Entity;
using Domain.IRepository;
using Repository.Context;

namespace Repository.Repository
{
    public class CompanyRepository : BaseRepository<Company>, ICompanyRepository
    {
        public CompanyRepository(HelpIncContext helpIncContext) : base(helpIncContext)
        {

        }
    }
}