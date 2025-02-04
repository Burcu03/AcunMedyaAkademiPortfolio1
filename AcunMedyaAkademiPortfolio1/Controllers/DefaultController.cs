using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaAkademiPortfolio1.Models;
namespace AcunMedyaAkademiPortfolio1.Controllers
{

    namespace AcunMedyaAkademiPortfolio1.Controllers
    {
        public class DefaultController : Controller
        {
            DbPortfolioEntities db = new DbPortfolioEntities();
            // GET: Default
            public ActionResult Index()
            {
                return View();
            }

            public PartialViewResult PartialHead()
            {
                return PartialView();
            }

            public PartialViewResult PartialNavbar()
            {
                return PartialView();
            }

            public PartialViewResult PartialFeature()
            {
                var values = db.TblFeature.ToList();
                return PartialView(values);
            }

            public PartialViewResult PartialAbout()
            {
                var values = db.TblAbout.ToList();
                return PartialView(values);
            }

            public PartialViewResult PartialSkill()
            {
                var values = db.TblSkill.ToList();
                return PartialView(values);
            }

            public PartialViewResult PartialStatistic()
            {
                var skillcount = db.TblSkill.ToList().Count(); 
                var testimonialcount = db.TblTestimonial.ToList().Count();
                var projectcount = db.TblProject.ToList().Count();
                var servicecount = db.TblService.ToList().Count();
                
                ViewBag.SkillCount = skillcount;
                ViewBag.TestimonialCount = testimonialcount;
                ViewBag.ProjectCount = projectcount;
                ViewBag.ServiceCount = servicecount;
                


                return PartialView();
            }

            public PartialViewResult PartialService()
            {
                var values = db.TblService.ToList();
                return PartialView(values);
            }

            public PartialViewResult ScriptPartial()
            {
                return PartialView();
            }

            public PartialViewResult PartialProject()
            {
                var values = db.TblProject.ToList();
                return PartialView(values);
            }


            public PartialViewResult PartialAddress()
            {
                var values = db.TblAdress.ToList();
                return PartialView(values);
            }

            [HttpGet]
            public PartialViewResult PartialContact()
            {

                return PartialView();
            }
            [HttpPost]
            public PartialViewResult PartialContact(TblContact y)
            {
                if (ModelState.IsValid)
                {
                    db.TblContact.Add(y);
                    db.SaveChanges();

                    ViewBag.RedirectUrl = Url.Action("Index", "Default");
                }
                return PartialView();
            }

            public PartialViewResult PartialHobby()
            {
                var values = db.TblHobby.ToList();
                return PartialView(values);
            }

            public PartialViewResult PartialProfile()
            {
                var values = db.TblProfile.ToList();
                return PartialView(values);
            }

            public PartialViewResult PartialTestimonial()
            {
                var values = db.TblTestimonial.ToList();
                return PartialView(values);
            }

            public PartialViewResult PartialFooter()
            {
                var values = db.TblService.ToList();

                return PartialView(values);
            }

        }
    }
}