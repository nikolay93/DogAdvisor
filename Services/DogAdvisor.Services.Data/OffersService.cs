namespace DogAdvisor.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;

    using DogAdvisor.Data.Common.Repositories;
    using DogAdvisor.Data.Models;
    using DogAdvisor.Services.Mapping;

    public class OffersService : IOffersService
    {
        private IRepository<Offer> OfferRepository { get; }

        public OffersService(IRepository<Offer> offerRepository)
        {
            this.OfferRepository = offerRepository;
        }

        public List<T> GetByCategory<T>(int categoryId)
        {
            var offers = this.OfferRepository
            .All()
            .Where(x => x.CategoryId == categoryId)
            .To<T>()
            .ToList();

            return offers;
        }
    }
}
