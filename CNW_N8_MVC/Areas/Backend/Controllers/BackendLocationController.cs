using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CNW_N8_MVC.Class;
using Newtonsoft.Json;
namespace CNW_N8_MVC.Areas.Backend.Controllers
{
    public class BackendLocationController : Controller
    {
        static Server.ServerSoapClient server = new Server.ServerSoapClient();
        // GET: Backend/BackendLocation

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddLocation(BE_Location location)
        {
            string json = JsonConvert.SerializeObject(location);
            server.BE_AddLocation(json);
            return RedirectToAction("List", "BackendLocation", new { area = "Backend" });
        }

        public ActionResult List()
        {
            var location = JsonConvert.DeserializeObject<List<BE_Location>>(server.BE_ListLocation());
            ViewData["locations"] = location;
            return View();
        }
        
        public ActionResult Edit(int id)
        {
            if (id == null)
            {
                return RedirectToAction("List", "BackendLocation", new { area = "Backend" });
            }
            else
            {
                int a;
                bool check = int.TryParse(id.ToString(), out a);
                if (check == true)
                {
                    var model = JsonConvert.DeserializeObject<List<BE_Location>>(server.BE_FindLocationByLocation_id(id));
                    if (model == null)
                    {
                        return RedirectToAction("List", "BackendLocation", new { area = "Backend" });
                    }
                    else
                    {
                        ViewData["acc"] = model;
                        return View();
                    }
                }
                else
                {
                    return RedirectToAction("List", "BackendLocation", new { area = "Backend" });
                }
            }
        }

        [HttpPost]
        public ActionResult EditLocation(BE_Location location)
        {
            string json = JsonConvert.SerializeObject(location);
            server.BE_EditLocation(json);
            return RedirectToAction("List", "BackendLocation", new { area = "Backend" });
        }
    }
}