using magazynWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace magazynWeb.Controllers
{
    public class ItemsController : Controller
    {
        // GET: Items
        public ActionResult Magazyny()
        {
            var magazyn = new Item();
            return View();
        }
    }
}