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
        public dynamic Get([FromBody]string value)
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

        // POST api/values
        public dynamic Post([FromBody]string value)
        {
            using (SmartControlEntities1 db = new SmartControlEntities1())
            {
                var sku = (from n in db.vw_UrlByStores
                           where n.Amazon==value  select n.SKU).ToList();
                return sku;
            }

        }

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
