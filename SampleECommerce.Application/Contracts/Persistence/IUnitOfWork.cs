using System;
using System.Threading.Tasks;

namespace SampleECommerce.Application.Contracts.Persistence
{
    public interface IUnitOfWork : IDisposable
    {

        Task Save();
    }
}
