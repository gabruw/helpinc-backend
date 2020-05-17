namespace Domain.Entity
{
    public class Geolocalization : Default
    {
        public long Id { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }

        public override void Validate()
        {
            throw new System.NotImplementedException();
        }
    }
}