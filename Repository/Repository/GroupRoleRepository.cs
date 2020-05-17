using Domain.Entity;
using Domain.IRepository;
using Repository.Context;

namespace Repository.Repository
{
    public class GroupRoleRepository : BaseRepository<GroupRole>, IGroupRoleRepository
    {
        public GroupRoleRepository(HelpIncContext helpIncContext) : base(helpIncContext)
        {

        }
    } 
}