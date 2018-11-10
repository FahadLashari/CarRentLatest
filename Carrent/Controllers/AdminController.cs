using Carrent.DBModels;
using Carrent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Carrent.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        ApplicationDbContext db = new ApplicationDbContext();
        [HttpGet]
        public ActionResult AdminVehicle()
        {
            var CarTypeList=db.CarTypes.ToList();
            ViewBag.CarTypeList= new SelectList(CarTypeList, "Id", "Name");
            return View();
        }
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public ActionResult AdminVehicle(CarInfo CarInfo)
        {
            var CarTypeList = db.CarTypes.ToList();
            ViewBag.CarTypeList = new SelectList(CarTypeList, "Id", "Name");
            long uno = DateTime.Now.Ticks;
            int counter = 0;
            foreach (string fcName in Request.Files)
            {
                HttpPostedFileBase File = Request.Files[fcName];
                if (!string.IsNullOrEmpty(File.FileName))
                {
                    string url = "/Images/Cars/" + uno + "_" + ++counter + File.FileName.Substring(File.FileName.LastIndexOf("."));
                    string Path = Request.MapPath(url);
                    File.SaveAs(Path);
                    CarInfo.ImageUrl = url;
                }
            }
            db.CarInfos.Add(CarInfo);
            db.SaveChanges();

            return Content("<script language= 'javascript' type= 'text/javascript'> alert('Car Added Successfully');</script>");
            
        }

        public ActionResult CarType(CarType Cartype)
        {
           db.CarTypes.Add(Cartype);
            db.SaveChanges();
            return View();
        }
    }
}