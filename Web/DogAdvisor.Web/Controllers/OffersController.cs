namespace DogAdvisor.Web.Controllers
{
    using System.Linq;

    using DogAdvisor.Services.Data;
    using DogAdvisor.Web.ViewModels.Offers;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;

    public class OffersController : Controller
    {
        private readonly IOffersService offersService;
        private readonly IOfferCategoriesService offerCategoriesService;

        public OffersController(IOffersService offersService, IOfferCategoriesService offerCategoriesService)
        {
            this.offersService = offersService;
            this.offerCategoriesService = offerCategoriesService;
        }

        public IActionResult Index(int categoryId)
        {
            var offers = this.offersService.GetByCategory<OfferViewModel>(categoryId);
            var offerCategories = this.offerCategoriesService.GetSelectListItems();

            var offersListViewModel = new OffersListViewModel
            {
                Offers = offers,
                Categories = offerCategories.Select(x =>
                new SelectListItem
                {
                    Text = x.Text,
                    Value = x.Value,
                }).ToList(),
            };

            return this.View(offersListViewModel);
        }
    }
}
