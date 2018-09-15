using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoManager.Proxies
{
    public class HttpClient : System.Net.Http.HttpClient
    {
        public static readonly HttpClient Instance = new HttpClient();
  
        static HttpClient()
        {
            Instance.BaseAddress = new Uri("https://localhost:44310");
        }
    }
}
