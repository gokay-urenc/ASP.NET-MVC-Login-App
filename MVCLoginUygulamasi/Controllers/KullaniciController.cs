using MVCLoginUygulamasi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MVCLoginUygulamasi.Controllers
{
    public class KullaniciController : BaseController
    {
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string adi,string soyadi)
        {
            // Parametrelerde gelen kullanıcıya ait veritabanında eşdeğer veri var mı yok mu kontrolünü yapıyoruz.
            Employee kullanici = db.Employees.FirstOrDefault(x => x.FirstName == adi && x.LastName == soyadi);
            FormsAuthentication.SetAuthCookie(kullanici.FirstName + " " + kullanici.LastName, true);
            // FormsAuthentication çalışabilmesi için Web.Config dosyasında system.web düğümü içerisine tanımlama yaptık.
            return RedirectToAction("Index","Home");
        }
    }
}