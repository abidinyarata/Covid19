namespace CovidApp
{
    public class Address
    {
        public int Id { get; set; }
        public string? OpenAddress { get; set; }
        public int CityId { get; set; }
        public virtual City? City { get; set; }
        public int DistrcitId { get; set; }
        public virtual District? District { get; set; }
    }
}