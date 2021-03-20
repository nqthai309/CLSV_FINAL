using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CNW_N8_MVC.Areas.Backend.Controllers
{
    public class BackendStatisticalController : Controller
    {
        // GET: Backend/BackendStatistical
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult OrderStatistical()
        {
            return View();
        }

        public ActionResult CommentStatistical()
        {
            return View();
        }
        public ActionResult RegisterStatistical()
        {
            return View();
        }

    }
}