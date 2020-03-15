namespace DogAdvisor.Web.ViewModels.Offers
{
    using DogAdvisor.Data.Models;
    using DogAdvisor.Services.Mapping;

    public class OfferViewModel : IMapFrom<Offer>
    {
        public string City { get; set; }

        public string Address { get; set; }

        public string Facility { get; set; }

        public string Overview { get; set; }
    }
}
