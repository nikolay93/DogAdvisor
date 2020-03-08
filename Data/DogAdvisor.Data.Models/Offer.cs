namespace DogAdvisor.Data.Models
{
    using DogAdvisor.Data.Common.Models;

    public class Offer : BaseModel<int>
    {
        public string City { get; set; }

        public string Address { get; set; }

        public string Facility { get; set; }

        public string Overview { get; set; }

        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        public int CategoryId { get; set; }

        public virtual OfferCategory Category { get; set; }
    }
}
