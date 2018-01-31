using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace AspWebScraper.Controllers
{
    public class WebScrapingController : Controller
    {
        // GET: WebScraping
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public string GetUrlSource(string url)
        {
            string htmlCode = "";
            using (WebClient client = new WebClient())
            {
                try
                {
                    htmlCode = client.DownloadString(url);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
            return htmlCode;
        }
    }
}