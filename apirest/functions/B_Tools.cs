using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restapi.functions
{
    public class B_Tools
    {
        public string GetDomainName(string url)
        {
            string domain = "";
            try
            {
                domain = new Uri(url).DnsSafeHost.ToLower();
                domain = domain.Replace("www.", "");
            }catch(Exception error){}
            
            return domain;
        }
    }
}
