namespace AdminClient.Model.Utility
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Net.Http;
    using System.Configuration;
    using System.Net.Http.Headers;
    using Newtonsoft.Json;
    using Microsoft.Extensions.Options;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Http.Features;
    using Microsoft.AspNetCore.Mvc;
    using System.Security.Claims;
    using Microsoft.Extensions.Configuration;

    public class HttpWebClients : IHttpWebClients
    {
    

       
        public IConfiguration _Iconfiguration { get; set; }
        public HttpWebClients(IConfiguration iconfiguration)
        {
            
         
            _Iconfiguration = iconfiguration;
        }


        public string PostRequest(string URI, string parameterValues, bool isAnonymous)
        {
            string jsonString = null;
           
                string BaseURI = _Iconfiguration["WebAPIBaseUrl"];
                string URL = BaseURI +"/"+ URI;
               

                using (var client = new HttpClient())
                {

                    client.BaseAddress = new Uri(URL);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    client.Timeout = TimeSpan.FromMinutes(20);
                    //GET Method  
                    HttpContent c = new StringContent(parameterValues, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = client.PostAsync(URL, c).Result;
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {

                        jsonString = response.Content.ReadAsStringAsync()
                                                       .Result
                                                       //.Replace("\\", "")
                                                       //.Replace("\r\n", "'")
                                                       .Trim(new char[1] { '"' });
                    }
                               
                     return jsonString;
                }
            
        }

    }
}
