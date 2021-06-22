using Refit;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PrismReactiveApp.Services
{
    public interface IFuelsApi
    {
        [Get("/api/fuels")]
        Task<HttpResponseMessage> GetFuels();
    }
}
