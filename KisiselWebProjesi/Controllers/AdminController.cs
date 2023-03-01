using KisiselWebProjesi.Models.Siniflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KisiselWebProjesi.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin

        Context c = new Context();
        [Authorize]
        public ActionResult Index()
        {
            var deger = c.Anasayfas.ToList();
            return View(deger);
        }

        public ActionResult AnasayfaGetir(int id)
        {
            var ag = c.Anasayfas.Find(id);
            return View("AnasayfaGetir", ag);
        }

        public ActionResult AnasayfaGüncelle(Anasayfa x)
        {
            var ag = c.Anasayfas.Find(x.id);
            ag.isim = x.isim;
            ag.profil = x.profil;
            ag.unvan = x.unvan;
            ag.aciklama = x.aciklama;
            ag.iletisim = x.iletisim;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult İkonListesi()
        {
            var deger = c.İkonlars.ToList();
            return View(deger);
        }
        [HttpGet]
        public ActionResult YeniIkon()
        {
            return View();

        }
        [HttpPost]
        public ActionResult YeniIkon(İkonlar i)
        {
            c.İkonlars.Add(i);
            c.SaveChanges();
            return RedirectToAction("İkonListesi");
        }

        public ActionResult ikonGetir(int id)
        {
            var ig = c.İkonlars.Find(id);
            return View("ikonGetir", ig);
        }
        public ActionResult ikonGuncelle(İkonlar i)
        {
            var ig = c.İkonlars.Find(i.id);
            ig.ikon = i.ikon;
            ig.link = i.link;
            c.SaveChanges();
            return RedirectToAction("İkonListesi");

        }

        public ActionResult ikonSil(int id)
        {
            var sl = c.İkonlars.Find(id);
            c.İkonlars.Remove(sl);
            c.SaveChanges();
            return RedirectToAction("İkonListesi");
        }
    }
}