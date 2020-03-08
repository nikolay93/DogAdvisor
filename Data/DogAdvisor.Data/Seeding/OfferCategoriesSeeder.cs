namespace DogAdvisor.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using DogAdvisor.Data.Models;

    public class OfferCategoriesSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.OfferCategories.Any())
            {
                return;
            }

            var categories = new List<string> {
                "Accommodation",
                "Family attractions",
                "Good for walks",
                "Indoor venues",
                "Pubs",
                "Shops and Services",
            };

            foreach (var category in categories)
            {
                var offerCategory = new OfferCategory
                {
                    Name = category,
                };

                dbContext.OfferCategories.Add(offerCategory);
            }
        }
    }
}
