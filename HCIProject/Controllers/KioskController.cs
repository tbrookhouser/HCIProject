using HCIProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HCIProject.Controllers
{
    public class KioskController : Controller
    {
        // GET: Kiosk
        public ActionResult Index()
        {
            HomeController home = new HomeController();
            LaundryRoom laundryRoom = home.InitializeLaundryRoom();
            return View(laundryRoom);
        }
    }
}