using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Rendering_and_Binding_Drop_Down_Lists.Models;

namespace Rendering_and_Binding_Drop_Down_Lists.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(new BestPictureViewModel());
        }

        public ActionResult Save(BestPictureViewModel viewmodel)
        {
            return View("Index", viewmodel);
        }
    }
}
