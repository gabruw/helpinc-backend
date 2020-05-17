using Domain.Entity;
using Domain.IRepository;
using Repository.Context;

namespace Repository.Repository
{
    public class GeolocalizationRepository : BaseRepository<Geolocalization>, IGeolocalizationRepository
    {
        public GeolocalizationRepository(HelpIncContext helpIncContext) : base(helpIncContext)
        {

        }
    }
}