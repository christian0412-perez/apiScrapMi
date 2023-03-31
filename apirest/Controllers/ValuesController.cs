using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using restapi.functions;
using Newtonsoft.Json;
using apirest.Models;

namespace apirest.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public dynamic Post([FromBody]string value)
        {
                string Response = restapi.functions.B_Urls.DoAll(value);
                if (Response.Substring(0, 5) == "Error")
                {
                    return Response;
                }
                else
                {
                    var json = JsonConvert.DeserializeObject(Response);
                    return json;
                }

            
        }
        public string Get()
        {
            return "error";
        }




        //// POST api/values
        //public dynamic Post([FromBody]string value)
        //{
        //    try
        //    {
        //        string response = B_Urls.BySku(value);
        //        var json = JsonConvert.DeserializeObject(response);
        //        return json;
        //    }
        //    catch
        //    {
        //        return "error";
        //    }

        //}

        // PUT api/values/5
        public void Get(int id)
        {
            B_Urls.doAllScraping(id);
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
