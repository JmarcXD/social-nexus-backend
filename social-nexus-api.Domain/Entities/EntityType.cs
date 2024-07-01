namespace social_nexus_api.Domain.Entities
{
    public class EntityType
    {
        public int EntityTypeId { get; set; }
        public string? EntityTypeName { get; set; }

        public virtual ICollection<Entity>? Entities { get; set;}
    }
}
