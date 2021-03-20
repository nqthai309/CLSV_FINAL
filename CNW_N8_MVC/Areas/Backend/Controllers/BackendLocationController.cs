using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CNW_N8_MVC.Areas.Backend.Controllers
{
    public class BackendLocationController : Controller
    {
        // GET: Backend/BackendLocation

        public ActionResult Add()
        {
            return View();
        }

        public ActionResult List()
        {
            return View();
        }
        
        public ActionResult Edit()
        {
            return View();
        }
    }
}