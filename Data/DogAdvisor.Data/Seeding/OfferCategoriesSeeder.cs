using DogAdvisor.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogAdvisor.Data.Seeding
{
    public class OfferCategoriesSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.OfferCategories.Any())
            {
                return;
            }

            var categories = new List<string> 
            {
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
