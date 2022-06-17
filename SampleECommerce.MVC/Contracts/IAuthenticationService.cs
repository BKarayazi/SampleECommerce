using SampleECommerce.MVC.Models;
using System.Threading.Tasks;

namespace SampleECommerce.MVC.Contracts
{
    public interface IAuthenticationService
    {
        Task<bool> Authenticate(string email, string password);
        Task<bool> Register(RegisterVM registration);
        Task Logout();
    }
}
