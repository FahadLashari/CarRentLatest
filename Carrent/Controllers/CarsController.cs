using Carrent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace Carrent.Controllers
{
    public class CarsController : Controller
    {
        // GET: Cars
        ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult ViewCars()
        {
            var CarList= db.CarInfos.Include(x=>x.CarType).ToList();
            ViewBag.CarList = CarList;
            return View();

        }
    }
}