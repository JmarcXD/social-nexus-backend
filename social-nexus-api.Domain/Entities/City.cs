namespace social_nexus_api.Domain.Entities
{
    public class City
    {
        public int CityId { get; set; }
        public string? CityName { get; set; } 
        public int CountryId { get; set; }

        public virtual Country? country { get; set; }
    }
}
