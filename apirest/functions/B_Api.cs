using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restapi.functions
{
    public class B_Api
    {
        public string GetRequest2(string url)
        {

            string strhtml = String.Empty;
            try
            {
                var client = new RestClient("http://localhost:8080");
                var request = new RestRequest("items", Method.Get);
                var response = client.Execute(request);
                Console.WriteLine(response.Content);
            }
            catch (Exception error)
            {

            }

            return strhtml;

        }
    }
}
