namespace DogAdvisor.Data.Models
{
    using System.Collections.Generic;

    using DogAdvisor.Data.Common.Models;

    public class OfferCategory : BaseModel<int>
    {
        public OfferCategory()
        {
            this.Offers = new HashSet<Offer>();
        }

        public string Name { get; set; }

        public virtual ICollection<Offer> Offers { get; set; }
    }
}
