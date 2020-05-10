using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCLoginUygulamasi.Controllers
{
    public class ProductController : BaseController
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult UrunleriGetir()
        {
            return View(db.Products.ToList());
        }
    }
}