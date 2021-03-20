using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Dynamic;
using CNW_N8_MVC.Entites;
using Newtonsoft.Json;
using CNW_N8_MVC.Class;
using CNW_N8_MVC.Controllers;

namespace CNW_N8_MVC.Areas.Backend.Controllers
{
    public class BackendHomeController : Controller
    {
        // GET: Backend/Home
        
        static Server.ServerSoapClient server = new Server.ServerSoapClient();
        // GET: Backend
        public ActionResult Index()
        {
            if (Session["LoginBackend"] == null)
            {
                return RedirectToAction("Login", "BackendHome", new { area = "Backend" });
            }
            else
            {
                return View();
            }
        }
        public ActionResult Login()
        {

            return View();
        }
        public int checkLoginBackend(string user, string pass)
        {
            //var result = context.users.Where(a => (a.username == user && a.password == pass && a.role_id == 0)).FirstOrDefault();
            var result = server.BE_FindUserByUsername_Password(user, pass);

            if (result != null)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }


        [HttpGet]
        public ActionResult LoginCenter(users acc)
        {
            var result = server.BE_FindUserByUsername_Password(acc.username, acc.password);
            if(result.Count() == 0)
            {
                return View("LoginFail");
            }
            else
            {
                Session["LoginBackend"] = acc;
                return RedirectToAction("Index", "BackendHome", new { area = "Backend" });
            }
            
        }
    }
}