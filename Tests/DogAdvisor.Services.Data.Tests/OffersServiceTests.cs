namespace DogAdvisor.Services.Data.Tests
{
    using System.Collections.Generic;
    using System.Linq;
    using AutoMapper;
    using DogAdvisor.Data.Common.Repositories;
    using DogAdvisor.Data.Models;
    using DogAdvisor.Web.ViewModels.Offers;
    using Moq;
    using Xunit;

    public class OffersServiceTests
    {
        [Fact]
        public void GetCountShouldReturnCorrectNumber()
        {
            var categoryId = 1;
            var offers = new List<Offer>
            {
             new Offer { CategoryId = 1, City = "London" },
             new Offer(),
             new Offer(),
            }.AsQueryable();

            var mapperMock = new Mock<IMapper>();
            mapperMock.Setup(m => m.Map<Offer, OfferViewModel>(It.IsAny<Offer>())).Returns(new OfferViewModel());

            var repository = new Mock<IRepository<Offer>>();
            repository.Setup(r => r.All()).Returns(offers);
            var service = new OffersService(repository.Object);

            Assert.Single(service.GetByCategory<OfferViewModel>(categoryId));
            repository.Verify(x => x.All(), Times.Once);
        }
    }
}
