using capp_ScarperByUrl.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capp_ScarperByUrl.Bussines
{
    public class B_GetUrl
    {
        #region
        public List<vw_UrlByStores> listUr()
        {
            try
            {
                using (SmartControlEntities db = new SmartControlEntities())
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
