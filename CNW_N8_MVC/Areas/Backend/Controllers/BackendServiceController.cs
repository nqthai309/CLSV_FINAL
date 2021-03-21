using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CNW_N8_MVC.Class;
using Newtonsoft.Json;

namespace CNW_N8_MVC.Areas.Backend.Controllers
{
    public class BackendServiceController : Controller
    {
        // GET: Backend/BackendService
        static Server.ServerSoapClient server = new Server.ServerSoapClient();

        public ActionResult List()
        {
            var services = JsonConvert.DeserializeObject<List<BE_Service>>(server.BE_ListService());
            ViewData["services"] = services;
            return View();
        }

        [HttpPost]
        public ActionResult EditService(BE_Service service)
        {
            string json = JsonConvert.SerializeObject(service);
            server.BE_EditService(json);
            return RedirectToAction("List", "BackendService", new { area = "Backend" });

        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddService(BE_Service service)
        {
            string json = JsonConvert.SerializeObject(service);
            server.BE_AddService(json);
            return RedirectToAction("List", "BackendService", new { area = "Backend" });
        }
        public ActionResult Edit(int id)
        {
            if (id == null)
            {
                return RedirectToAction("List", "BackendService", new { area = "BackendService" });
            }
            else
            {
                int a;
                bool check = int.TryParse(id.ToString(), out a);
                if (check == true)
                {
                    var service = JsonConvert.DeserializeObject<List<BE_Service>>(server.BE_FindServiceByService_id(id));
                    if (service == null)
                    {
                        return RedirectToAction("List", "BackendService", new { area = "BackendService" });
                    }
                    else
                    {
                        ViewData["service"] = service;
                        return View();
                    }
                }
                else
                {
                    return RedirectToAction("List", "BackendService", new { area = "BackendService" });
                }
            }
        }  
    }
}