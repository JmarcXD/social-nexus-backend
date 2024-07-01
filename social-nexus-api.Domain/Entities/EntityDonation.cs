namespace social_nexus_api.Domain.Entities
{
    public class EntityDonation
    {
        public int EntityDonationId { get; set; }
        public DateTime DateDonated { get; set; }
        public int EntityId { get; set; }
        public int DonationId { get; set; }

        public virtual ICollection<Entity>? Entities { get; set; }
        public virtual ICollection<Donation>? Donations { get; set; }
    }
}
