using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        //public string Index()
        //{
        //    return "This is my <b>defult</b> action...";
        //}
        public string welcome(string name, int numTime=1)
        {
            return HttpUtility.HtmlEncode( "Hello: " +name+",ID: "+numTime);

        }
        public ActionResult Index()
        {
            return View();
        }
    }
}