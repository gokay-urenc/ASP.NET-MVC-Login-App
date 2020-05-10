using MVCLoginUygulamasi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCLoginUygulamasi.Controllers
{
    public class CategoryController : BaseController
    {
        public ActionResult Index()
        {
            return View();
        }

      
        [Authorize] // Kullanıcı giriş yapmış mı yapmamış mı diye cookie'yi kontrol eder.
        public ActionResult KategoriGetir()
        {
            return View(db.Categories.ToList());
        }
    }
}