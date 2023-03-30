using apirest;
using apirest.Models;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace restapi.functions
{
    public class B_GetUrl
    {
        #region
        public List<vw_UrlByStores> listUr()
        {
            try
            {
                using (SmartControlEntities1 db = new SmartControlEntities1())
                {
                    var listUrl = (from n in db.vw_UrlByStores
                                   select n).ToList();
                    return listUrl;
                }
            }
            catch
            {
                return null;
            }

        }
        #endregion
    }
}
