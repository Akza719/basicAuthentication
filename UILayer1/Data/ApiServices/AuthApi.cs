using DomainLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using UILayer.Models;

namespace UILayer.Data.ApiServices
{
    public class AuthApi
    {
        public static void GetProduct()
        {
            ResponseModel<string> _responseModel = null;
            using (HttpClient httpClient = new HttpClient())
            {
                _responseModel = new ResponseModel<string>();
                string url = "http://localhost:22887/api/admin";
                Uri uri = new Uri(url);
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Authorization", "basic ");
                System.Threading.Tasks.Task<HttpResponseMessage> result = httpClient.GetAsync(uri);
                if (result.Result.IsSuccessStatusCode)
                {
                    System.Threading.Tasks.Task<string> response = result.Result.Content.ReadAsStringAsync();
                    _responseModel = Newtonsoft.Json.JsonConvert.DeserializeObject<ResponseModel<string>>(response.Result);
                }
                
            }
        }
    }
}
