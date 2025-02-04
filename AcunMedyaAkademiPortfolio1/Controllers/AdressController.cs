using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaAkademiPortfolio1.Models;

namespace AcunMedyaAkademiPortfolio1.Controllers
{
    
    public class AdressController : Controller
    {
        DbPortfolioEntities db = new DbPortfolioEntities();
        public ActionResult Index()
        {
            var values = db.TblAdress.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateAdress()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateAdress(TblAdress p)
        {
            db.TblAdress.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteAdress(int id)
        {
            var value = db.TblAdress.Find(id);
            db.TblAdress.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateAdress(int id)
        {
            var value = db.TblAdress.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateAdress(TblAdress p)
        {
            var value = db.TblAdress.Find(p.AdressId);
            value.Adress = p.Adress;
            value.Phone = p.Phone;
            value.Email = p.Email;
            value.Website = p.Website;
          //  value.Status = true;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}