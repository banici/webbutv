using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace ClientService
{
    public static class ClientHelper
    {
        public static HttpClient ClientApi = new HttpClient();

        static ClientHelper()
        {
            ClientApi.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            ClientApi.BaseAddress = new Uri("http://localhost:49402/api/");
            ClientApi.DefaultRequestHeaders.Clear();
        }
    }
}
