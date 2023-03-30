using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capp_ScarperByUrl.Bussines;
using capp_ScarperByUrl.Classes;
using capp_ScarperByUrl.DataBase;
using Newtonsoft.Json;
using System.Threading;
namespace capp_ScarperByUrl.Bussines
{
    public class B_Urls
    {
        public static string DoAll(string url)
        {
            string strHtmlWalmart = string.Empty;
            string strHtmlTarget = string.Empty;
            string strHtmlBestbuy = string.Empty;
            string strHtmlAmazon = string.Empty;
            string strMessageError = "";
            string response = string.Empty;
            bool needAwait = false;

            Bussines.B_GetUrl b_GetUrl = new Bussines.B_GetUrl();

            Bussines.B_Functions b_Functions = new Bussines.B_Functions();
            //Get List url Walmart
            List<vw_UrlByStores> listUrl = b_GetUrl.listUr();
            B_Tools b_Tools = new B_Tools();
            Console.WriteLine(listUrl);


            needAwait = false;
            var domain = b_Tools.GetDomainName(url);
            if (domain == "walmart.com")
            {
                Console.WriteLine("Get html Walmart url: " + url);
                //Get html Walmart
                strHtmlWalmart = b_Functions.GetRequest(12, "Walmart", url, "example");
                if (strHtmlWalmart.Length > 0)
                {
                    //Scraper values in html and save values
                    Console.WriteLine("Scraper Walmart");
                    object result = b_Functions.DataParse_Walmart(strHtmlWalmart, 12, "Walmart", url, "example");
                    Console.WriteLine("Result:");
                    Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
                    response = JsonConvert.SerializeObject(result, Formatting.Indented);
                    needAwait = true;

                }
                else
                {
                    Console.WriteLine("Error url de walmart invalida: " + url);
                    response = "Error url invalida: " + url;
                    N_P_SendEmail n_P_SendEmail = new N_P_SendEmail();
                    //n_P_SendEmail.sendEmail("Scraper Walmart Link Error", "Invalid link <br>SKU:" + atributos.SKU + "<br> Url: " + atributos.Walmart);
                }

            }

            if (domain == "target.com")
            {
                //Get html Target
                Console.WriteLine("Get html Target url: " + url);
                strHtmlTarget = b_Functions.GetRequest(12, "Target", url, "example");
                if (strHtmlTarget.Length > 0)
                {
                    //Scraper values in html and save values
                    Console.WriteLine("Scraper Target");
                    object result = b_Functions.DataParse_Target(strHtmlTarget, 12, "Target", url, "example");
                    Console.WriteLine("Result:");
                    Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
                    response = JsonConvert.SerializeObject(result, Formatting.Indented);
                    needAwait = true;
                }
                else
                {
                    Console.WriteLine("Error url de target invalida: " + url);
                    N_P_SendEmail n_P_SendEmail = new N_P_SendEmail();
                    response = "Error url invalida: " + url;
                    //n_P_SendEmail.sendEmail("Scraper Walmart Link Error", "Invalid link <br>SKU:" + atributos.SKU + "<br> Url: " + atributos.Target);
                }

            }

            if (domain == "amazon.com")
            {
                //Get html Amazon
                Console.WriteLine("Get html Target url: " + url);
                strHtmlAmazon = b_Functions.GetRequest(12, "Amazon", url, "example");
                if (strHtmlAmazon.Length > 0)
                {
                    //Scraper values in html and save values
                    Console.WriteLine("Scraper Amazon");
                    object result = b_Functions.DataParse_Amazon(strHtmlAmazon, 12, "Amazon", url, "example");
                    Console.WriteLine("Result:");
                    Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
                    needAwait = true;
                    response = JsonConvert.SerializeObject(result, Formatting.Indented);
                }
                else
                {
                    Console.WriteLine("Error url de amazon invalida: " + url);
                    N_P_SendEmail n_P_SendEmail = new N_P_SendEmail();
                    response = "Error url invalida: " + url;
                    //n_P_SendEmail.sendEmail("Scraper Walmart Link Error", "Invalid link <br>SKU:" + atributos.SKU + "<br> Url: " + atributos.Amazon);
                }

            }

            if (domain == "amazon.com.mx")
            {
                //Get html Amazon
                Console.WriteLine("Get html Target url: " + url);
                strHtmlAmazon = b_Functions.GetRequest(12, "AmazonMx", url, "example");
                if (strHtmlAmazon.Length > 0)
                {
                    //Scraper values in html and save values
                    Console.WriteLine("Scraper AmazonMx");
                    object result = b_Functions.DataParse_AmazonMx(strHtmlAmazon, 12, "AmazonMx", url, "example");
                    Console.WriteLine("Result:");
                    Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
                    needAwait = true;
                    response = JsonConvert.SerializeObject(result, Formatting.Indented);
                }
                else
                {
                    Console.WriteLine("Error url de amazonmx invalida: " + url);
                    N_P_SendEmail n_P_SendEmail = new N_P_SendEmail();
                    response = "Error url de amazonmx invalida: " + url;
                    //n_P_SendEmail.sendEmail("Scraper Walmart Link Error", "Invalid link <br>SKU:" + atributos.SKU + "<br> Url: " + atributos.AmazonMx);
                }
            }

            if (domain == "mercadolibre.com.mx" || domain == "articulo.mercadolibre.com.mx")
            {
                //Get html Amazon
                Console.WriteLine("Get html Target url: " + url);
                strHtmlAmazon = b_Functions.GetRequest(12, "MercadoLibreMx", url, "example");
                if (strHtmlAmazon.Length > 0)
                {
                    //Scraper values in html and save values
                    Console.WriteLine("Scraper MercadoLibreMx");
                    object result = b_Functions.DataParse_MercadoLibreMx(strHtmlAmazon, 12, "MercadoLibreMx", url, "example");
                    Console.WriteLine("Result:");
                    Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
                    needAwait = true;
                    response = JsonConvert.SerializeObject(result, Formatting.Indented);
                }
                else
                {
                    Console.WriteLine("Error url invalida: " + url);
                    N_P_SendEmail n_P_SendEmail = new N_P_SendEmail();
                    response = "Error url invalida: " + url;
                    //n_P_SendEmail.sendEmail("Scraper Walmart Link Error", "Invalid link <br>SKU:" + atributos.SKU + "<br> Url: " + atributos.MercadoLibreMx);
                }
            }

            //}
            //if (needAwait)
            //    Thread.Sleep(8000);

            return response;
        }

        public static void doAllScraping()
        {
            string strHtmlWalmart = string.Empty;
            string strHtmlTarget = string.Empty;
            string strHtmlBestbuy = string.Empty;
            string strHtmlAmazon = string.Empty;
            string strMessageError = "";
            bool needAwait = false;

            Bussines.B_GetUrl b_GetUrl = new Bussines.B_GetUrl();

            Bussines.B_Functions b_Functions = new Bussines.B_Functions();
            //Get List url Walmart
            List<vw_UrlByStores> listUrl = b_GetUrl.listUr();
            B_Tools b_Tools = new B_Tools();
            Console.WriteLine(listUrl);
            if (listUrl.Count > 0)
            {
                foreach (var atributos in listUrl)
                {
                    needAwait = false;
                    if (atributos.NeddUpdate_Walmart == 1)
                    {
                        var domain = b_Tools.GetDomainName(atributos.Walmart);
                        if (domain == "walmart.com")
                        {
                            Console.WriteLine("Get html Walmart url: " + atributos.Walmart);
                            //Get html Walmart
                            strHtmlWalmart = b_Functions.GetRequest(atributos.SKURetailLinkID, "Walmart", atributos.Walmart, atributos.SKU);
                            if (strHtmlWalmart.Length > 0)
                            {
                                //Scraper values in html and save values
                                Console.WriteLine("Scraper Walmart");
                                object result = b_Functions.DataParse_Walmart(strHtmlWalmart, atributos.SKURetailLinkID, "Walmart", atributos.Walmart, atributos.SKU);
                                Console.WriteLine("Result:");
                                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
                                needAwait = true;
                            }
                            else
                            {
                                Console.WriteLine("Error url invalida: " + atributos.Walmart);
                                N_P_SendEmail n_P_SendEmail = new N_P_SendEmail();
                                //n_P_SendEmail.sendEmail("Scraper Walmart Link Error", "Invalid link <br>SKU:" + atributos.SKU + "<br> Url: " + atributos.Walmart);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Error url invalida: " + atributos.Walmart);
                            N_P_SendEmail n_P_SendEmail = new N_P_SendEmail();
                            strMessageError += "Error dominio debe ser walmart.com y contiene: " + domain + " SKU: " + atributos.SKU + " Url: " + atributos.Walmart + "<br>";
                            //n_P_SendEmail.sendEmail("Scraper Walmart Link Error", "Invalid link only USA <br>SKU:" + atributos.SKU + "<br> Url: " + atributos.Walmart);
                        }
                    }

                    if (atributos.NeddUpdate_Target == 1)
                    {
                        var domain = b_Tools.GetDomainName(atributos.Walmart);
                        if (domain == "target.com")
                        {
                            //Get html Target
                            Console.WriteLine("Get html Target url: " + atributos.Target);
                            strHtmlTarget = b_Functions.GetRequest(atributos.SKURetailLinkID, "Target", atributos.Target, atributos.SKU);
                            if (strHtmlTarget.Length > 0)
                            {
                                //Scraper values in html and save values
                                Console.WriteLine("Scraper Target");
                                object result = b_Functions.DataParse_Target(strHtmlTarget, atributos.SKURetailLinkID, "Target", atributos.Target, atributos.SKU);
                                Console.WriteLine("Result:");
                                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
                                needAwait = true;
                            }
                            else
                            {
                                Console.WriteLine("Error url invalida: " + atributos.Target);
                                N_P_SendEmail n_P_SendEmail = new N_P_SendEmail();
                                //n_P_SendEmail.sendEmail("Scraper Walmart Link Error", "Invalid link <br>SKU:" + atributos.SKU + "<br> Url: " + atributos.Target);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Error url invalida: " + atributos.Target);
                            N_P_SendEmail n_P_SendEmail = new N_P_SendEmail();
                            //n_P_SendEmail.sendEmail("Scraper Target Link Error", "Invalid link only USA <br>SKU:" + atributos.SKU + "<br> Url: " + atributos.Target);
                        }

                    }

                    //if (atributos.NeddUpdate_Bestbuy == 1)
                    //{
                    //    var domain = b_Tools.GetDomainName(atributos.Bestbuy);

                    //    if(domain == "bestbuy.com")
                    //    {
                    //        //Get html Bestbuy
                    //        Console.WriteLine("Get html Target url: " + atributos.Bestbuy);
                    //        //strHtmlBestbuy = b_Functions.GetRequest3(atributos.Bestbuy);
                    //        // Scraper values in html and save values
                    //        Console.WriteLine("Scraper Bestbuy");
                    //        object result = b_Functions.DataParse_Bestbuy(atributos.SKURetailLinkID, "Bestbuy", atributos.Bestbuy, atributos.SKU);
                    //        Console.WriteLine("Result:");
                    //        Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
                    //        needAwait = true;
                    //    }
                    //    else
                    //    {
                    //        Console.WriteLine("Error url invalida: " + atributos.Bestbuy);
                    //        N_P_SendEmail n_P_SendEmail = new N_P_SendEmail();
                    //        //n_P_SendEmail.sendEmail("Scraper Bestbuy Link Error", "Invalid link only USA <br>SKU:" + atributos.SKU + "<br> Url: " + atributos.Bestbuy);
                    //    }
                    //}

                    if (atributos.NeddUpdate_Amazon == 1)
                    {
                        var domain = b_Tools.GetDomainName(atributos.Amazon);

                        if (domain == "amazon.com")
                        {
                            //Get html Amazon
                            Console.WriteLine("Get html Target url: " + atributos.Amazon);
                            strHtmlAmazon = b_Functions.GetRequest(atributos.SKURetailLinkID, "Amazon", atributos.Amazon, atributos.SKU);
                            if (strHtmlAmazon.Length > 0)
                            {
                                //Scraper values in html and save values
                                Console.WriteLine("Scraper Amazon");
                                object result = b_Functions.DataParse_Amazon(strHtmlAmazon, atributos.SKURetailLinkID, "Amazon", atributos.Amazon, atributos.SKU);
                                Console.WriteLine("Result:");
                                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
                                needAwait = true;
                            }
                            else
                            {
                                Console.WriteLine("Error url invalida: " + atributos.Amazon);
                                N_P_SendEmail n_P_SendEmail = new N_P_SendEmail();
                                //n_P_SendEmail.sendEmail("Scraper Walmart Link Error", "Invalid link <br>SKU:" + atributos.SKU + "<br> Url: " + atributos.Amazon);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Error url invalida: " + atributos.Amazon);
                            N_P_SendEmail n_P_SendEmail = new N_P_SendEmail();
                            //n_P_SendEmail.sendEmail("Scraper Walmart Link Error", "Invalid link only USA <br>SKU:" + atributos.SKU + "<br> Url: " + atributos.Amazon);
                        }

                    }

                    if (atributos.NeddUpdate_AmazonMx == 1)
                    {
                        var domain = b_Tools.GetDomainName(atributos.AmazonMx);

                        if (domain == "amazon.com.mx")
                        {
                            //Get html Amazon
                            Console.WriteLine("Get html Target url: " + atributos.AmazonMx);
                            strHtmlAmazon = b_Functions.GetRequest(atributos.SKURetailLinkID, "AmazonMx", atributos.AmazonMx, atributos.SKU);
                            if (strHtmlAmazon.Length > 0)
                            {
                                //Scraper values in html and save values
                                Console.WriteLine("Scraper AmazonMx");
                                object result = b_Functions.DataParse_AmazonMx(strHtmlAmazon, atributos.SKURetailLinkID, "AmazonMx", atributos.AmazonMx, atributos.SKU);
                                Console.WriteLine("Result:");
                                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
                                needAwait = true;
                            }
                            else
                            {
                                Console.WriteLine("Error url invalida: " + atributos.AmazonMx);
                                N_P_SendEmail n_P_SendEmail = new N_P_SendEmail();
                                //n_P_SendEmail.sendEmail("Scraper Walmart Link Error", "Invalid link <br>SKU:" + atributos.SKU + "<br> Url: " + atributos.AmazonMx);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Error url invalida: " + atributos.AmazonMx);
                            N_P_SendEmail n_P_SendEmail = new N_P_SendEmail();
                            //n_P_SendEmail.sendEmail("Scraper Walmart Link Error", "Invalid link only USA <br>SKU:" + atributos.SKU + "<br> Url: " + atributos.AmazonMx);
                        }

                    }

                    if (atributos.NeddUpdate_MercadoLibreMx == 1)
                    {
                        var domain = b_Tools.GetDomainName(atributos.MercadoLibreMx);

                        if (domain == "mercadolibre.com.mx")
                        {
                            //Get html Amazon
                            Console.WriteLine("Get html Target url: " + atributos.MercadoLibreMx);
                            strHtmlAmazon = b_Functions.GetRequest(atributos.SKURetailLinkID, "MercadoLibreMx", atributos.MercadoLibreMx, atributos.SKU);
                            if (strHtmlAmazon.Length > 0)
                            {
                                //Scraper values in html and save values
                                Console.WriteLine("Scraper MercadoLibreMx");
                                object result = b_Functions.DataParse_MercadoLibreMx(strHtmlAmazon, atributos.SKURetailLinkID, "MercadoLibreMx", atributos.MercadoLibreMx, atributos.SKU);
                                Console.WriteLine("Result:");
                                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
                                needAwait = true;
                            }
                            else
                            {
                                Console.WriteLine("Error url invalida: " + atributos.MercadoLibreMx);
                                N_P_SendEmail n_P_SendEmail = new N_P_SendEmail();
                                //n_P_SendEmail.sendEmail("Scraper Walmart Link Error", "Invalid link <br>SKU:" + atributos.SKU + "<br> Url: " + atributos.MercadoLibreMx);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Error url invalida: " + atributos.MercadoLibreMx);
                            N_P_SendEmail n_P_SendEmail = new N_P_SendEmail();
                            //n_P_SendEmail.sendEmail("Scraper Walmart Link Error", "Invalid link only USA <br>SKU:" + atributos.SKU + "<br> Url: " + atributos.MercadoLibreMx);
                        }

                    }
                    if (needAwait)
                        Thread.Sleep(8000);
                }
            }

        }

    }
}

