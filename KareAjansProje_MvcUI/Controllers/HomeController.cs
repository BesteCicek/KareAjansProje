using KareAjansProje_Business.Abstracts;
using KareAjansProje_Business.Concretes.Managers;
using KareAjansProje_DataAccess.Concretes.EntityFramework;
using KareAjansProje_Entities.Concretes;
using KareAjansProje_MvcUI.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KareAjansProje_MvcUI.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        IMankenService _mankenManager = MankenManager.CreateSingleton(new EfMankenDal());
        KareAjansContext _db = new KareAjansContext();
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Manken manken)
        {
            if (!ModelState.IsValid)
            {
                return View(manken);
            }
            KareAjansContext db = new KareAjansContext();
            Manken loginManken = db.Mankens.FirstOrDefault(m => m.KullaniciAdi == manken.KullaniciAdi && m.Sifre == manken.Sifre);
            if (loginManken != null)
            {
                Session["myLogin"] = loginManken;
                return RedirectToAction("ListMankens");
            }

            ModelState.AddModelError("", "Kullanici adi veya sifre yanlistir");
            return View(manken);
        }
        [HttpGet]
        public ActionResult ListMankens()
        {
            ListMankens model = new ListMankens
            {
                Mankens = _mankenManager.GetMankens()
            };
            return View(model);
        }
        [HttpGet]
        public ActionResult UpdateManken(int id)
        {
            ManiMankenViewModel model = new ManiMankenViewModel
            {
                Manken = _db.Mankens.Find(id),
                Bedens = _db.Bedens.ToList(),
                SacRengis = _db.SacRengis.ToList(),
                GozRengis = _db.GozRengis.ToList()
            };

            return View(model);
        }
        [HttpPost]
        public ActionResult UpdateManken(Manken manken)
        {
            if (!ModelState.IsValid)
            {
                ManiMankenViewModel model = new ManiMankenViewModel
                {
                    Manken = _db.Mankens.Find(manken.MankenID),
                    Bedens = _db.Bedens.ToList(),
                    SacRengis = _db.SacRengis.ToList(),
                    GozRengis = _db.GozRengis.ToList()
                };

                return View(model);
            }

            _db.Entry(_db.Mankens.Find(manken.MankenID)).CurrentValues.SetValues(manken);
            _db.SaveChanges();

            TempData["message"] = "Veri guncellendi";

            return RedirectToAction("ListMankens");
        }
    }
}