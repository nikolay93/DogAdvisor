namespace DogAdvisor.Services.Data
{
    using System.Collections.Generic;

    public interface IOffersService
    {
        List<T> GetByCategory<T>(int categoryId);
    }
}
