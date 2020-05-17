using Domain.Entity;
using Domain.IRepository;
using Repository.Context;

namespace Repository.Repository
{
    public class ConsumerRepository : BaseRepository<Consumer>, IConsumerRepository
    {
        public ConsumerRepository(HelpIncContext helpIncContext) : base(helpIncContext)
        {

        }
    }
}