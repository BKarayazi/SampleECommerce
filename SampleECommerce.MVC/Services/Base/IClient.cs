using System.Net.Http;

namespace SampleECommerce.MVC.Services.Base
{
    public partial interface IClient
    {
        public HttpClient HttpClient { get; }

    }
}
