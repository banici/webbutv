using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Administrator
{
    public static class WebsiteClient
    {
        public static HttpClient WebApiClient = new HttpClient();

        static WebsiteClient()
        {
            WebApiClient.BaseAddress = new Uri("http://localhost:49402/api/");
            WebApiClient.DefaultRequestHeaders.Clear();
            WebApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
