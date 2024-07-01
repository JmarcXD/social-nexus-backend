namespace social_nexus_api.Domain.Entities
{
    public class Headquarter
    {
        public int HeadquarterId { get; set; }
        public string? HeadquarterName { get; set;}
        public string? HeadquarterPhoneNumber { get; set;}
        public string? HeadquarterEmail { get; set;}
        public string? HeadquarterDirection { get; set;}
        public int EntityId { get; set;}
        public int CityId { get; set;}

        public virtual Entity? entity { get; set;}
        public virtual City? city { get; set;}
    }
}
