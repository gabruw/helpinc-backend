using Domain.Entity;
using Domain.IRepository;
using Repository.Context;

namespace Repository.Repository
{
    public class SkillLevelRepository : BaseRepository<SkillLevel>, ISkillLevelRepository
    {
        public SkillLevelRepository(HelpIncContext helpIncContext) : base(helpIncContext)
        {

        }
    }
}