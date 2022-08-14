using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShopBook.Models;

namespace ShopBook.Controllers
{
    public class ShopController : Controller
    {
        // GET: Shop
        public ActionResult Random()
        {
            var shop = new Shop() { Name = "RACT" };
            return View(shop);
        }
    }
}