using Domain.Entity;
using Domain.IRepository;
using Repository.Context;

namespace Repository.Repository
{
    public class GroupRepository : BaseRepository<Group>, IGroupRepository
    {
        public GroupRepository(HelpIncContext helpIncContext) : base(helpIncContext)
        {

        }
    }
}