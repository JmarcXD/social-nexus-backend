namespace social_nexus_api.Domain.Entities
{
    public class Country
    {
        public int CountryId { get; set; }
        public string? CountryName { get; set; }

        public virtual ICollection<City>? Cities { get; set; }
        public virtual ICollection<Entity>? Entities { get; set; }
    }
}
