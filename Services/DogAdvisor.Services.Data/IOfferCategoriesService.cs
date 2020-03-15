namespace DogAdvisor.Services.Data
{
    using System.Collections.Generic;

    using DogAdvisor.Services.Data.HelperModels.OfficeCategories;

    public interface IOfferCategoriesService
    {
        List<CategorySelectedListItem> GetSelectListItems();
    }
}
