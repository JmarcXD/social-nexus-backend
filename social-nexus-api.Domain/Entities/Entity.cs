namespace social_nexus_api.Domain.Entities
{
    public class Entity
    {
        public int EntityId { get; set; }
        public string? EntityName { get; set; }
        public string? EntityPhoneNumber { get; set; }
        public string? EntityEmail { get; set; }
        public DateOnly DateEntityCreated { get; set; }
        public int EntityTypeId { get; set; }
        public int CountryId { get; set; }
        public int UserId { get; set; }

        public virtual ICollection<EntityDonation>? EntityDonations { get; set; }
        public virtual ICollection<EntitySector>? EntitySectors { get; set; }
        public virtual EntityType? EntityType { get; set; }


    }
}
