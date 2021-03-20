using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CNW_N8_MVC.Areas.Backend.Controllers
{
    public class BackendRoleController : Controller
    {
        // GET: Backend/BackendRole
        public ActionResult Edit()
        {
            return View();
        }
        
        public ActionResult Add()
        {
            return View();
        }

        public ActionResult List()
        {
            return View();
        }
    }
}