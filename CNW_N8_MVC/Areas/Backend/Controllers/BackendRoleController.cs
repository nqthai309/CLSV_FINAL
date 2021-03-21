using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CNW_N8_MVC.Class;
using Newtonsoft.Json;

namespace CNW_N8_MVC.Areas.Backend.Controllers
{
    public class BackendRoleController : Controller
    {
        static Server.ServerSoapClient server = new Server.ServerSoapClient();
        // GET: Backend/BackendRole
        public ActionResult Edit()
        {
            return View();
        }
        
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddRole(Role acc)
        {
            string json = JsonConvert.SerializeObject(acc);
            server.BE_AddRole(json);
            return RedirectToAction("List", "BackendRole", new { area = "Backend" });
        }

        public ActionResult List()
        {
            List<Role> listRole = new List<Role>();
            listRole = JsonConvert.DeserializeObject<List<Role>>(server.BE_GetListRole());
            return View(listRole);
        }

        public ActionResult DeleteRole(string id)
        {
            if (id == null)
            {
                return RedirectToAction("List", "BackendRole", new { area = "Backend" });
            }
            else
            {
                int a;
                bool check = int.TryParse(id.ToString(), out a);
                if (check == true)
                {
                    var result = server.FE_FindRoleByRole_id(a.ToString());
                    if (result == null)
                    {
                        return RedirectToAction("List", "BackendRole", new { area = "Backend" });
                    }
                    else
                    {
                        server.BE_DeleteRole(int.Parse(id));
                        return RedirectToAction("List", "BackendRole", new { area = "Backend" });
                    }

                }
            }
            return View();
        }
    }
}