namespace Domain.Entity
{
    public class Company : Actor
    {
        public string TradingName { get; set; }
        public long Cnpj { get; set; }
    }
}
