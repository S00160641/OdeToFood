using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Controllers
{
    //[Authorize] // Must be logged in
    public class CuisineController : Controller
    {
        // Get: Cuisine, Post: Cuisine
        public ActionResult Search(string name)
        {
            var message = Server.HtmlEncode(name); // Prevents XXS

            return Content(message);
        }
    }
}