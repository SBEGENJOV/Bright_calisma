using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using System.Net.Http.Headers;

namespace mvcProject
{
    public class GlobalVariebles
    {
        public static HttpClient webapiclient = new HttpClient();
        static GlobalVariebles()
        {
            webapiclient.BaseAddress = new Uri("https://localhost:44377/api/");
            webapiclient.DefaultRequestHeaders.Clear();
            webapiclient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}