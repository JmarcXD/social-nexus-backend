namespace social_nexus_api.Domain.Entities
{
    public class Donation
    {
        public int DonationId { get; set; }
        public int QuantityDonated { get; set; }

        public virtual ICollection<EntityDonation>? EntityDonations { get; set; }
    }
}
