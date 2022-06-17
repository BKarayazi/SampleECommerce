using SampleECommerce.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleECommerce.Application.Contracts.Persistence
{
    public interface IOfferRepository : IGenericRepository<Offer>
    {
        Task<Offer> GetOfferWithDetails(Guid id);
        Task<List<Offer>> GetOffersWithDetails();
        Task<List<Offer>> GetOffersWithDetails(Guid itemId);

    }
}
