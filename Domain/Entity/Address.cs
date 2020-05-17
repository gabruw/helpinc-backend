namespace Domain.Entity
{
    public class Address : Default
    {
        public long Id { get; set; }
        public long IdGeolocalization { get; set; }
        public virtual Geolocalization GeolocalizationAddress { get; set; }
        public string Road { get; set; }
        public string Neighborhood { get; set; }
        public int Number { get; set; }
        public int Complement { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int Cep { get; set; }
        public string Reference { get; set; }

        public override void Validate()
        {
            throw new System.NotImplementedException();
        }
    }
}