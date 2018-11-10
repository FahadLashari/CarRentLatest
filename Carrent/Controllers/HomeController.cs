using Carrent.DBModels;
using Carrent.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Carrent.Controllers
{
    public class HomeController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        [HttpGet]
        public ActionResult Index()
        {
            var CarInfoList = db.CarInfos.ToList();
            ViewBag.CarInfoList = new SelectList(CarInfoList, "Id", "Name");
            return View();
        }
        [HttpPost]
        public ActionResult Index(Rent model)
        {
            var CarInfoList = db.CarInfos.ToList();
            ViewBag.CarInfoList = new SelectList(CarInfoList, "Id", "Name");
            db.Rents.Add(model);
            var car= db.CarInfos.Find(model.CarInfoId);
            car.IsAvailable = false;
            db.Entry(car).State = EntityState.Modified;
            db.SaveChanges();
            return View();
        }
        public ActionResult IsCarAvailable(int Id)
        {
            var car = db.CarInfos.Find(Id);
            if (car.IsAvailable)
            {
                return Json("IsAvailable", JsonRequestBehavior.AllowGet);
            }
                return Json("NotAvailable", JsonRequestBehavior.AllowGet);
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