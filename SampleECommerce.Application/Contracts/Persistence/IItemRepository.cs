using SampleECommerce.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleECommerce.Application.Contracts.Persistence
{
    public interface IItemRepository : IGenericRepository<Item>
    {
        Task<Item> GetItemWithDetails(int id);
        Task<List<Item>> GetItemsWithDetails();
        Task<List<Item>> GetItemsWithDetails(string userId);

    }
}
