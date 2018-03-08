using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HCIProject.Models;

namespace HCIProject.Controllers
{
    public class HomeController : Controller
    {

        public LaundryRoom InitializeLaundryRoom()
        {
            Washer washer1 = new Washer(1, "1", "open");
            Washer washer2 = new Washer(2, "2", "open");
            Washer washer3 = new Washer(3, "3", "busy");
            Washer washer4 = new Washer(4, "4", "idle");
            Washer washer5 = new Washer(5, "5", "open");

            List<Washer> washerList = new List<Washer>();
            washerList.Add(washer1);
            washerList.Add(washer2);
            washerList.Add(washer3);
            washerList.Add(washer4);
            washerList.Add(washer5);

            Dryer dryer1 = new Dryer(1, "1", "open");
            Dryer dryer2 = new Dryer(2, "2", "busy");
            Dryer dryer3 = new Dryer(3, "3", "idle");
            Dryer dryer4 = new Dryer(4, "4", "open");
            Dryer dryer5 = new Dryer(5, "5", "idle");

            List<Dryer> dryerList = new List<Dryer>();
            dryerList.Add(dryer1);
            dryerList.Add(dryer2);
            dryerList.Add(dryer3);
            dryerList.Add(dryer4);
            dryerList.Add(dryer5);

            LaundryRoom laundryRoom = new LaundryRoom();
            laundryRoom.washerList = washerList;
            laundryRoom.dryerList = dryerList;
            return laundryRoom;

        }

        public ActionResult Index()
        {
            LaundryRoom laundryRoom = InitializeLaundryRoom();

            return View(laundryRoom);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}