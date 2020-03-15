namespace DogAdvisor.Web.ViewModels.Offers
{
    using System.Collections.Generic;

    using Microsoft.AspNetCore.Mvc.Rendering;

    public class OffersListViewModel
    {
        public int CategoryId { get; set; }

        public List<SelectListItem> Categories { get; set; }

        public List<OfferViewModel> Offers { get; set; }
    }
}
