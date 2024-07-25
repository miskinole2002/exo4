using Serveur.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.Mvc;

namespace Serveur.Controllers
{
    public class AlarmController : Controller
    {
        // GET: Alarm
        public ActionResult Index()
        {
            //using (var db = new SystDb())
            //{
            //    var conn = db.Security.Count();
            //    db.Security.Add(new Securite
            //    {







            //        Status = 0,
            //        Z1 = "off",
            //        Z2 = "off",
            //        Z3 = "off",
            //        Z4 = "off",
                    

            //    });
            //    db.SaveChanges();
            //}
            return View();
        }

        public JsonResult GetAllSystInfos()
        {
            using (var db = new SystDb())
            {
                var conn = db.Security.ToList();

                db.SaveChanges();
                return Json(conn, JsonRequestBehavior.AllowGet);

            }
        }

        [HttpPost]
        public JsonResult UpdateStateGui( string Status)
        {
            using (var db = new SystDb())
            {
               // int x = 1;
                var conn = db.Security.Find(1);
               
                conn.Status = Convert.ToInt32(Status);
                db.SaveChanges();
                var con = db.Security.ToList();

                return Json(con, JsonRequestBehavior.AllowGet);

            }
           // return View();
        }

        public JsonResult UpdateStatePi(Securite i)
        {
            using (var db = new SystDb())
            {
                var conn = db.Security.Find(i.Id);
                conn.Status = i.Status;
                conn.Z1 = i.Z1;
                conn.Z2= i.Z2;
                conn.Z3= i.Z3;
                conn.Z4= i.Z4;
                db.SaveChanges();
                var con = db.Security.ToList();

                return Json(con, JsonRequestBehavior.AllowGet);

            }
        }
    }
}