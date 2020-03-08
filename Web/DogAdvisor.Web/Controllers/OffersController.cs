namespace DogAdvisor.Web.Controllers
{

    using DogAdvisor.Services.Data;
    using DogAdvisor.Web.ViewModels.Offers;
    using Microsoft.AspNetCore.Mvc;

    public class OffersController : Controller
    {
        private readonly IOffersService offersService;

        public OffersController(IOffersService offersService)
        {
            this.offersService = offersService;
        }

        public IActionResult Index(int categoryId)
        {
            var offers = this.offersService.GetByCategory<OfferViewModel>(categoryId);

            var offersListViewModel = new OffersListViewModel
            {
                Offers = offers,
            };

            return View(offersListViewModel);
        }
    }
}