using System;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using capp_ScarperByUrl.Classes;
using capp_ScarperByUrl.DataBase;
using HtmlAgilityPack;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace capp_ScarperByUrl.Bussines
{
    public class B_Functions
    {
        N_P_SendEmail n_P_SendEmail = new N_P_SendEmail();

        public string GetRequest(int SKURetailLinkID, string Store, string Link, string SKU)
        {

            string strhtml = String.Empty;
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Link);

                request.AutomaticDecompression = DecompressionMethods.GZip;

                request.UserAgent = "Mozilla/5.0(Windows NT 10.0; Win64; x64)AppleWebKit/537.36(KHTML, like Gecko)Chrome/71.0.3578.98Safari/537.36";

                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())

                using (Stream stream = response.GetResponseStream())

                using (StreamReader reader = new StreamReader(stream))

                {

                    strhtml = reader.ReadToEnd();

                }

                strhtml = WebUtility.HtmlDecode(strhtml);
            }
            catch(Exception error)
            {
                //UpdateSKURetailLinksDetails_ErrorLink(SKURetailLinkID, SKU, Store, Link, "This page could not be found.");
            }           

            return strhtml;

        }

        public string GetRequest2(string url)
        {

            string strhtml = String.Empty;
            try
            {
                var client = new RestClient(url);
                //var request = new RestRequest("", Method.Get);
                //client.Timeout = -1;
                var request = new RestRequest("", Method.Get);
                request.AddHeader("Cookie", "_abck=DCA30B83133F5B6054F6F8BC882523D7~-1~YAAQxenHF7piKWSFAQAAryTKpwmfpCudP9PF7qrMXKOk9XBY/L2DRzE04BC72PjjX+ABf0W+Mzq+bXaG4u+jWTXPAY69hpDDU6tImZxorANBmO3CG+WBpFiyz64mR9rP73BqNaV117E9B4X3Ds4tzN6bi/JRL2yRT4mmaujHcp+XgcU2Rc3/xtlyqk3SiJfRqlGohK1hxbXvlEO2D9/DFH1w12bKeV1v0pBBjQ/5xjnihJS5NMChVeaL8bVTkGBqAnU9Wj1EG7udXGPvQF1HmQ8VBDUzsQMcQYRmr6b60RMDgG3SjeNaU+fHUj3yPOu7FTt6yOFPPe9HioJ/waZbCV3C5IaC/TWIYXIkgaW1~-1~-1~-1; ak_bmsc=C90202168172DC61CFA5B5254E262546~000000000000000000000000000000~YAAQxenHF7tiKWSFAQAAryTKpxL+32ghYcfHOqqCw/Mm7beYud/qLrC51Zr2LHPE3ay4LNGpp3K5J3Dt13K6fv8iJBGpY/nD3ixL8Ng9Vo6rkpi+VUQLuOXC31kYnJwdR1ZiNxHmc2gwDFEEz+twuCrEWEd+XQoIk+6xhxQO/oJf4e6Fpz8/plsXRzFkLnCJeVMHs9EA+TzhGc9dzXp2OES5lgfYQUWu3Ax2/FTbwLBao8aIo+9RYQIl17k3yKzoVOpm+3g6IPChMOZBF++DU4immmKaOTmBD8F5W8VvcyYpnuRrLpPtT+Pwk9Hd/+zs+aYmSuXDfDdWEzS2TV3PJf9PmurlPn0hpBshebIaSsDYrFAALVRQ69XNCrE=; bm_sz=7561085D4E89CADC255AFEA9E0902C5B~YAAQxenHF71iKWSFAQAAryTKpxKxEvypLA2tMRWaWMv0OMGYQQfDd8jdTOdZ2tP7g1OGp9F1MSHnJcHY/ccXMr+QvXSyV2v4mL1x5YdqH/fUizK+jSkMqxCShbK4RYN6nj7PRo0NeRJdwmptivPy612j8mzkrxioilnjF/rDEoMjP7yxz+lKINwNLxwax6nwdRz4o+tQd/jA3hK0H4AU5oIG8CqOK7Exsxq8S805Ed6x3lXaqTdoqsT8eu/oNQ5S1zK7MC8p97kTQJ/mF085ybs5ptojVqo2ti+kfgXVBeXm7ONorDLemhNvFwNvkquRaH1WP4+24N2kr2tYuJO0qjHfpfNk4W07KBypNBQjPSuNK7jqQOz02igPaRARUkyezQ==~4474181~3617332; search_abtesting_5050_conversion=A");
                RestResponse response = client.Execute(request);
                strhtml=response.Content;
            }
            catch (Exception error)
            {

            }

            return strhtml;

        }        

        public object DataParse_Walmart(string strHtml,int SKURetailLinkID, string Store,string Link,string SKU)
        {
            /*
             * key tags
             * Create: Pavel Torres
             * Date: 2022-01-10
             */
            SKURetailLinksDetail ScraperDetail = new SKURetailLinksDetail();

            ScraperDetail.SKURetailLinkID = SKURetailLinkID;
            ScraperDetail.Store = Store;
            ScraperDetail.Link = Link;
            ScraperDetail.MITSKU = SKU;

            string v_Title = "";
            decimal v_Price = 0;
            string v_PriceCurrency = "USD";
            bool v_Available = true;
            try
            {
                HtmlDocument htmlDocument = new HtmlDocument();
                htmlDocument.LoadHtml(strHtml);
                try
                {
                    var sScriptJSON = htmlDocument.DocumentNode.Descendants("script")
                    .Where(node => node.GetAttributeValue("type", "")
                    .Equals("application/ld+json")).FirstOrDefault().InnerHtml;
                    JObject objJSON = JObject.Parse(sScriptJSON);

                    v_Title = (string)objJSON["name"];

                    string rssPrice = (string)objJSON["offers"]["price"];

                    v_Price = Convert.ToDecimal(rssPrice);

                    string rssAvailable = (string)objJSON["offers"]["availability"];
                    if(rssAvailable== "https://schema.org/OutOfStock")
                        v_Available = false;
                }
                catch (Exception error) { }

                ScraperDetail.Available = v_Available;
                ScraperDetail.Title = v_Title;
                ScraperDetail.RetailPrice = v_Price;
                ScraperDetail.PriceCurrency = v_PriceCurrency;
                ScraperDetail.Active = true;
                ScraperDetail.UpdateNow = false;
                ScraperDetail.CreaterUser = "sys_cappScraperByUrl";
                ScraperDetail.Timestamp = DateTime.Now;
                ScraperDetail.Balance = 0;

                InsertScrapDetail(ScraperDetail);
            }
            catch (Exception error)
            {
                Console.WriteLine("*** Error DataParse");
            }
            
            return new
            {
                Title = v_Title,
                Price = v_Price,
                Available = v_Available,
                PriceCurrency= v_PriceCurrency,
            };
        }

        public object DataParse_Target(string strHtml, int SKURetailLinkID, string Store, string Link, string SKU)
        {
            SKURetailLinksDetail ScraperDetail = new SKURetailLinksDetail();

            ScraperDetail.SKURetailLinkID = SKURetailLinkID;
            ScraperDetail.Store = Store;
            ScraperDetail.Link = Link;
            ScraperDetail.MITSKU = SKU;

            string v_Title = "";
            decimal v_Price = 0;
            string v_PriceCurrency = "USD";
            bool v_Available = true;
            try
            {

                HtmlAgilityPack.HtmlDocument htmlDocument = new HtmlAgilityPack.HtmlDocument();
                htmlDocument.LoadHtml(strHtml);

                var sTitle = htmlDocument.DocumentNode.Descendants("h1")
                    .Where(node => node.GetAttributeValue("data-test", "")
                    .Equals("product-title")).FirstOrDefault().InnerHtml.Replace("<span>","").Replace("</span>", "");
                var ress = htmlDocument.DocumentNode.SelectSingleNode("//script[contains(., 'current_retail')]").InnerText;
                
                int pFrom = ress.IndexOf("current_retail") + "current_retail".Length;
                int pTo = ress.LastIndexOf("external_system_id");

                String result_Price = ress.Substring(pFrom, pTo - pFrom);
                result_Price = result_Price.Replace("\\", "").Replace(":", "").Replace(",","").Replace(" ","").Replace("\"", ""); ;
                
                v_Title = sTitle;
                try
                {
                    v_Price = Convert.ToDecimal(result_Price);
                }
                catch (Exception error)
                {
                }               

                ScraperDetail.Available = v_Available;
                ScraperDetail.Title = v_Title;
                ScraperDetail.RetailPrice = v_Price;
                ScraperDetail.PriceCurrency = v_PriceCurrency;
                ScraperDetail.Active = true;
                ScraperDetail.UpdateNow = false;
                ScraperDetail.CreaterUser = "sys_cappScraperByUrl";
                ScraperDetail.Timestamp = DateTime.Now;
                ScraperDetail.Balance = 0;

                //InsertScrapDetail(ScraperDetail);
            }
            catch (Exception error)
            {
                Console.WriteLine("*** Error DataParse");
            }



            return new
            {
                Title = v_Title,
                Price = v_Price,
                Available = v_Available,
                PriceCurrency = v_PriceCurrency,
            };
        }

        //public object DataParse_Bestbuy(int SKURetailLinkID, string Store, string Link, string SKU)
        //{
        //    IWebDriver driver = new ChromeDriver();
        //    driver.Navigate().GoToUrl(Link);

        //    SKURetailLinksDetail ScraperDetail = new SKURetailLinksDetail();

        //    ScraperDetail.SKURetailLinkID = SKURetailLinkID;
        //    ScraperDetail.Store = Store;
        //    ScraperDetail.Link = Link;
        //    ScraperDetail.MITSKU = SKU;

        //    string v_Title = "";
        //    decimal v_Price = 0;
        //    string v_PriceCurrency = "USD";
        //    bool v_Available = true;
        //    try
        //    {

        //        try
        //        {
        //            var IsProductInactive = driver.FindElement(By.XPath("//p[@class='inactive-product-message v-fw-medium lv']")).Text;
        //            if (IsProductInactive != "")
        //            {
        //                v_Available = false;
        //            }
        //        }
        //        catch(Exception error) { }


        //        var sTitle = "";
        //        try
        //        {
        //            sTitle = driver.FindElement(By.XPath("//div[@class='sku-title']")).Text;
                    
        //        }
        //        catch(Exception error) {
        //            sTitle = driver.FindElement(By.XPath("//a[@data-track='Product Description']")).Text;
        //        }
        //        //try
        //        //{
        //            var sPrice = driver.FindElement(By.XPath("//div[@class='priceView-hero-price priceView-customer-price']/span")).Text.Replace("$", "");
        //        //}
        //        //catch(Exception error) { }

                


        //        v_Title = sTitle;
        //        try
        //        {
        //            v_Price = Convert.ToDecimal(sPrice);
        //        }
        //        catch (Exception error)
        //        {
        //        }

        //        driver.Quit();
        //        driver.Dispose();

        //        ScraperDetail.Available = v_Available;
        //        ScraperDetail.Title = v_Title;
        //        ScraperDetail.RetailPrice = v_Price;
        //        ScraperDetail.PriceCurrency = v_PriceCurrency;
        //        ScraperDetail.Active = true;
        //        ScraperDetail.UpdateNow = false;
        //        ScraperDetail.CreaterUser = "sys_cappScraperByUrl";
        //        ScraperDetail.Timestamp = DateTime.Now;
        //        ScraperDetail.Balance = 0;

        //        InsertScrapDetail(ScraperDetail);                
        //    }
        //    catch (Exception error)
        //    {
        //        Console.WriteLine("*** Error DataParse");
        //    }
        //    return new
        //    {
        //        Title = v_Title,
        //        Price = v_Price,
        //        Available = v_Available,
        //        PriceCurrency = v_PriceCurrency,
        //    };
        //}

        public object DataParse_Amazon(string strHtml, int SKURetailLinkID, string Store, string Link, string SKU)
        {
            SKURetailLinksDetail ScraperDetail = new SKURetailLinksDetail();

            ScraperDetail.SKURetailLinkID = SKURetailLinkID;
            ScraperDetail.Store = Store;
            ScraperDetail.Link = Link;
            ScraperDetail.MITSKU = SKU;

            string v_Title = "";
            decimal v_Price = 0;
            string v_PriceCurrency = "USD";
            bool v_Available = true;
            try
            {

                HtmlAgilityPack.HtmlDocument htmlDocument = new HtmlAgilityPack.HtmlDocument();
                htmlDocument.LoadHtml(strHtml);

                var sTitle = htmlDocument.DocumentNode.Descendants("span")
                .Where(node => node.GetAttributeValue("id", "")
                .Equals("productTitle")).FirstOrDefault().InnerText.Trim();

                var sPrice = htmlDocument.DocumentNode.Descendants("span")
                .Where(node => node.GetAttributeValue("class", "")
                .Equals("a-offscreen")).FirstOrDefault().InnerText.Replace("$", "").Trim();

                v_Title = sTitle;
                try
                {
                    v_Price = Convert.ToDecimal(sPrice);
                }
                catch (Exception error)
                {
                }

                ScraperDetail.Available = v_Available;
                ScraperDetail.Title = v_Title;
                ScraperDetail.RetailPrice = v_Price;
                ScraperDetail.PriceCurrency = v_PriceCurrency;
                ScraperDetail.Active = true;
                ScraperDetail.UpdateNow = false;
                ScraperDetail.CreaterUser = "sys_cappScraperByUrl";
                ScraperDetail.Timestamp = DateTime.Now;
                ScraperDetail.Balance = 0;

                //InsertScrapDetail(ScraperDetail);
            }
            catch (Exception error)
            {
                Console.WriteLine("*** Error DataParse");
            }
            return new
            {
                Title = v_Title,
                Price = v_Price,
                Available = v_Available,
                PriceCurrency = v_PriceCurrency,
            };
        }

        public object DataParse_AmazonMx(string strHtml, int SKURetailLinkID, string Store, string Link, string SKU)
        {
            SKURetailLinksDetail ScraperDetail = new SKURetailLinksDetail();

            ScraperDetail.SKURetailLinkID = SKURetailLinkID;
            ScraperDetail.Store = Store;
            ScraperDetail.Link = Link;
            ScraperDetail.MITSKU = SKU;

            string v_Title = "";
            decimal v_Price = 0;
            string v_PriceCurrency = "MXN";
            bool v_Available = true;
            try
            {

                HtmlDocument htmlDocument = new HtmlDocument();
                htmlDocument.LoadHtml(strHtml);

                var sTitle = htmlDocument.DocumentNode.Descendants("span")
                .Where(node => node.GetAttributeValue("id", "")
                .Equals("productTitle")).FirstOrDefault().InnerText.Trim();

                var sbPrice = htmlDocument.DocumentNode.Descendants("span")
                .Where(node => node.GetAttributeValue("class", "")
                .Equals("a-price aok-align-center reinventPricePriceToPayMargin priceToPay")).FirstOrDefault();

                var sPrice = sbPrice.Descendants("span")
                .Where(node => node.GetAttributeValue("class", "")
                .Equals("a-offscreen")).FirstOrDefault().InnerText.Replace("$", "").Trim(); 


                v_Title = sTitle;
                try
                {
                    v_Price = Convert.ToDecimal(sPrice);
                    //Convert USD
                    // B_Operations b_Operations = new B_Operations();
                    // v_Price = b_Operations.WSConvertMxnToUsd(v_Price);
                }
                catch (Exception error)
                {
                }

                ScraperDetail.Available = v_Available;
                ScraperDetail.Title = v_Title;
                ScraperDetail.RetailPrice = v_Price;
                ScraperDetail.PriceCurrency = v_PriceCurrency;
                ScraperDetail.Active = true;
                ScraperDetail.UpdateNow = false;
                ScraperDetail.CreaterUser = "sys_cappScraperByUrl";
                ScraperDetail.Timestamp = DateTime.Now;
                ScraperDetail.Balance = 0;

                //InsertScrapDetail(ScraperDetail);
            }
            catch (Exception error)
            {
                Console.WriteLine("*** Error DataParse");
            }
            return new
            {
                Title = v_Title,
                Price = v_Price,
                Available = v_Available,
                PriceCurrency = v_PriceCurrency,
            };
        }

        public object DataParse_MercadoLibreMx(string strHtml, int SKURetailLinkID, string Store, string Link, string SKU)
        {
            SKURetailLinksDetail ScraperDetail = new SKURetailLinksDetail();

            ScraperDetail.SKURetailLinkID = SKURetailLinkID;
            ScraperDetail.Store = Store;
            ScraperDetail.Link = Link;
            ScraperDetail.MITSKU = SKU;

            string v_Title = "";
            decimal v_Price = 0;
            string v_PriceCurrency = "MXN";
            bool v_Available = true;
            try
            {

                HtmlDocument htmlDocument = new HtmlDocument();
                htmlDocument.LoadHtml(strHtml);

                var sTitle = htmlDocument.DocumentNode.Descendants("h1")
                .Where(node => node.GetAttributeValue("class", "")
                .Equals("ui-pdp-title")).FirstOrDefault().InnerText.Trim();

                var sPrice = htmlDocument.DocumentNode.Descendants("span")
                .Where(node => node.GetAttributeValue("class", "")
                .Equals("andes-money-amount__fraction")).FirstOrDefault().InnerText.Replace("$", "").Trim();

                v_Title = sTitle;
                try
                {
                    v_Price = Convert.ToDecimal(sPrice);
                    //Convert USD
                    // B_Operations b_Operations = new B_Operations();
                    // v_Price = b_Operations.WSConvertMxnToUsd(v_Price);
                }
                catch (Exception error){}

                ScraperDetail.Available = v_Available;
                ScraperDetail.Title = v_Title;
                ScraperDetail.RetailPrice = v_Price;
                ScraperDetail.PriceCurrency = v_PriceCurrency;
                ScraperDetail.Active = true;
                ScraperDetail.UpdateNow = false;
                ScraperDetail.CreaterUser = "sys_cappScraperByUrl";
                ScraperDetail.Timestamp = DateTime.Now;
                ScraperDetail.Balance = 0;

                //InsertScrapDetail(ScraperDetail);
            }
            catch (Exception error)
            {
                Console.WriteLine("*** Error DataParse");
            }
            return new
            {
                Title = v_Title,
                Price = v_Price,
                Available = v_Available,
                PriceCurrency = v_PriceCurrency,
            };
        }

        public bool UpdateSKURetailLinksDetails_ErrorLink(int SKURetailLinkID,string SKU, string Store, string Link, string CommentError )
        {
            bool updteError = true;
            SKURetailLinksDetail ScraperDetail = new SKURetailLinksDetail();
            ScraperDetail.SKURetailLinkID = SKURetailLinkID;
            ScraperDetail.Store = Store;
            ScraperDetail.Link = Link;
            ScraperDetail.MITSKU = SKU;
            ScraperDetail.Title = "";
            ScraperDetail.PriceCurrency = "USD";
            ScraperDetail.RetailPrice = 0;
            ScraperDetail.Available = false;
            ScraperDetail.Balance = 0;
            ScraperDetail.Active = false;
            ScraperDetail.Comment = CommentError;
            ScraperDetail.UpdateNow = false;
            ScraperDetail.CreaterUser = "sys_cappScraperByUrl";
            ScraperDetail.Timestamp = DateTime.Now;

            using (SmartControlEntities db = new SmartControlEntities())
            {
                var existedItem = db.SKURetailLinksDetails.Where(x => x.MITSKU == ScraperDetail.MITSKU && x.Store == ScraperDetail.Store).FirstOrDefault();
                if (existedItem != null)
                {
                    existedItem.RetailPrice = 0;
                    existedItem.Available = false;
                    existedItem.Balance = 0;
                    existedItem.Active = false;
                    existedItem.Comment = CommentError;
                    existedItem.UpdateNow = false;
                    existedItem.CreaterUser = "sys_cappScraperByUrl";
                    existedItem.Timestamp = DateTime.Now;
                    //db.Entry(existedItem).State = EntityState.Modified;
                }
                else
                {
                    //db.SKURetailLinksDetails.Add(ScraperDetail);
                }
                //db.SaveChanges();
            }

            return updteError;
            
        }

        public bool InsertScrapDetail(SKURetailLinksDetail ScraperDetail)
        {
            bool InsertScrap = true;
            try
            {
                using (SmartControlEntities db = new SmartControlEntities())
                {
                    var existedItem = db.SKURetailLinksDetails.Where(x => x.MITSKU == ScraperDetail.MITSKU && x.Store == ScraperDetail.Store).FirstOrDefault();
                    if (existedItem != null)
                    {
                        if (ScraperDetail.RetailPrice < existedItem.RetailPrice)
                        {
                            existedItem.Balance = 2;
                        }
                        else if (ScraperDetail.RetailPrice > existedItem.RetailPrice)
                        {
                            existedItem.Balance = 1;
                        }
                        else if (existedItem.RetailPrice == ScraperDetail.RetailPrice)
                        {
                            existedItem.Balance = 0;
                        }
                        existedItem.RetailPrice = ScraperDetail.RetailPrice;
                        existedItem.Available = ScraperDetail.Available;
                        existedItem.Timestamp = ScraperDetail.Timestamp;
                        existedItem.UpdateNow = ScraperDetail.UpdateNow;
                        ScraperDetail.Active = ScraperDetail.Active;
                        //db.Entry(existedItem).State = EntityState.Modified;
                    }
                    else
                    {
                       // db.SKURetailLinksDetails.Add(ScraperDetail);
                    }
                    //db.SaveChanges();
                }
            }
            catch(Exception error)
            {
                InsertScrap = false;
            }
            return InsertScrap;
               
        }

    }


}
