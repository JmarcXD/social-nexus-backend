namespace social_nexus_api.Domain.Entities
{
    public class Sector
    {
        public int SectorId { get; set; }
        public string? SectorName { get; set;}

        public virtual ICollection<EntitySector>? EntitySectors { get; set; }
    }
}
