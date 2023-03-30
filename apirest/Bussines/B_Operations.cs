using capp_ScarperByUrl.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capp_ScarperByUrl.Bussines
{
    public class B_Operations
    {
        public decimal WSConvertMxnToUsd(decimal PriceMXN)
        {
            decimal result = 0;
            try
            {
                decimal valueMXN=0;
                string scurrency = "MXN";
                using (BinManagerEntities bmdb = new BinManagerEntities())
                {
                    //Get Exchange rate by base is USD
                    var valueChangeMXN = (from n in bmdb.ExchageRates
                                          where n.Currency == scurrency
                                          select n.Rate
                                          ).FirstOrDefault();
                    //Convert value to decimal
                    valueMXN = Convert.ToDecimal(valueChangeMXN);
                }
                //Convert Price MXN to USD
                result = PriceMXN / valueMXN;
                result = Math.Round(result, 2);
            }
            catch(Exception error) { }
            return result;
        }

        public decimal BMConvertMxnToUsd(decimal PriceMXN)
        {
            decimal result = 0;
            try
            {
                decimal valueMXN = 0;
                using (BinManagerEntities bdb = new BinManagerEntities())
                {
                    //Get Exchange rate by base is USD
                    var valueChangeMXN = (from n in bdb.ExchageRates
                                            where n.Currency.Equals("MXN")
                                          select n.Rate ).FirstOrDefault();
                    //Convert value to decimal
                    valueMXN = Convert.ToDecimal(valueChangeMXN);
                }
                //Convert Price MXN to USD
                result = PriceMXN / valueMXN;
                result = Math.Round(result, 2);
            }
            catch (Exception error) { }
            return result;
        }
    }
}
