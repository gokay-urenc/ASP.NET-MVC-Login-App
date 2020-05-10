using MVCLoginUygulamasi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCLoginUygulamasi.Controllers
{
    public class BaseController : Controller
    {
        public NorthwndEntities db = new NorthwndEntities();
    }
}