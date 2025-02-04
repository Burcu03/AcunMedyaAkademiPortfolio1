using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaAkademiPortfolio1.Models;

namespace AcunMedyaAkademiPortfolio1.Controllers
{
    public class StatisticController : Controller
    {
        DbPortfolioEntities db = new DbPortfolioEntities();
        public ActionResult Index()
        {
            var skillcount = db.TblSkill.ToList().Count();
            var testimonialcount = db.TblTestimonial.ToList().Count();
            var projectcount = db.TblProject.ToList().Count();
            var servicecount = db.TblService.ToList().Count();
            var categorycount = db.TblCategory.Count();


            var contactcount = db.TblContact.ToList().Count();
            var contactname = db.TblContact.ToList().OrderByDescending(m => m.CreateDate).Select(m => m.Name).FirstOrDefault();// Son Gönderilen Mesajın Göndereni
            var hobbycount = db.TblHobby.ToList().Count();
            var categoryname = db.TblCategory.ToList().OrderByDescending(c => c.CategoryId).Select(c => c.CategoryName).FirstOrDefault();// En Son Eklenen Kategori
            var skillvalue = db.TblSkill.ToList().OrderByDescending(s => s.Value).Select(s => s.Title).FirstOrDefault(); // En Çok Kullanılan Yetenek

            var skillavgvalue = db.TblSkill.Average(x => x.Value);
            var lastskilltitlename = db.GetLastSkillTitle().FirstOrDefault();
            var mvccategoryprojectcount = db.TblProject.Where(x => x.ProjectCategory == 4).Count();

            ViewBag.ContactCount = contactcount;
            ViewBag.LastMessageSender = contactname;
            ViewBag.HobbyCount = hobbycount;
            ViewBag.LastCategory = categoryname;
            ViewBag.SkillValue = skillvalue;

            ViewBag.SkillCount = skillcount;
            ViewBag.TestimonialCount = testimonialcount;
            ViewBag.ProjectCount = projectcount;
            ViewBag.ServiceCount = servicecount;

            ViewBag.CategoryCount = categorycount;
            ViewBag.skillAvgValue = skillavgvalue;
            ViewBag.lastSkillTitleName = lastskilltitlename;
            ViewBag.mvcCategoryProjectCount = mvccategoryprojectcount;

            return View();
        }
    }
}