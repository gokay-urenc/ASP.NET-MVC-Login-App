using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCLoginUygulamasi.Controllers
{
    public class EmployeeController : BaseController
    {
        public ActionResult Index()
        {
            return View();
        }

        [Authorize]
        public ActionResult CalisanlariGetir()
        {
            return View();
        }

        public ActionResult _CalisanPartial()
        {
            return PartialView(db.Employees.ToList()); // Partial View dönecek actionlar return kısmında PartialView methodunu kullanmalıdır.
        }
    }
}