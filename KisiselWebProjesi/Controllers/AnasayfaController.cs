﻿using KisiselWebProjesi.Models.Siniflar;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Web;
using System.Web.Mvc;

namespace KisiselWebProjesi.Controllers
{
    public class AnasayfaController : Controller
    {
        // GET: Anasayfa

        Context c=new Context();
        public ActionResult Index()
        {
            var deger = c.Anasayfas.ToList();
            return View(deger);
        }

        public PartialViewResult ikonlar()
        {
            var deger = c.İkonlars.ToList();
            return PartialView(deger);
        }
    }
}