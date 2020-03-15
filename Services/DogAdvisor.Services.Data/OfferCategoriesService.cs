namespace DogAdvisor.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;

    using DogAdvisor.Data.Common.Repositories;
    using DogAdvisor.Data.Models;
    using DogAdvisor.Services.Data.HelperModels.OfficeCategories;

    public class OfferCategoriesService : IOfferCategoriesService
    {
        private readonly IRepository<OfferCategory> offerCategories;

        public OfferCategoriesService(IRepository<OfferCategory> offerCategories)
        {
            this.offerCategories = offerCategories;
        }

        public List<CategorySelectedListItem> GetSelectListItems()
        {
            var categories = this.offerCategories
                .All()
                .Select(x => new CategorySelectedListItem
                {
                    Text = x.Name,
                    Value = x.Id.ToString(),
                })
                .ToList();

            return categories;
        }
    }
}
