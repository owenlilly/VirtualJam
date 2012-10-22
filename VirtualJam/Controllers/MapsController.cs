using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.IO;

namespace VirtualJam.Controllers
{
    public class MapsController : Controller
    {
        //
        // GET: /Maps/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public string Index(PostObj data)
        {
            return data.Content;
        }

        public string HttpGet(string data)
        {
            //return data;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://search.twitter.com/search.json?q="+data);
            request.Method = "GET";
            request.Timeout = 15000;

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            string result = "";

            using(StreamReader reader = new StreamReader(response.GetResponseStream()))
            {
                result = reader.ReadToEnd();
            }

            return string.IsNullOrWhiteSpace(result) ? "Sorry, no data  retrieved..." : "Query string: "+data + "<br>" + result;
        }
    }

    public class PostObj
    {
        public string Content { get; set; }
    }
}
