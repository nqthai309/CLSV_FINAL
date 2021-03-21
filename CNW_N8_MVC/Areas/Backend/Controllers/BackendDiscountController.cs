using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CNW_N8_MVC.Class;
using Newtonsoft.Json;
namespace CNW_N8_MVC.Areas.Backend.Controllers
{
    public class BackendDiscountController : Controller
    {
        static Server.ServerSoapClient server = new Server.ServerSoapClient();
        static string id_old;
        // GET: Backend/BackendDiscount
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return RedirectToAction("List", "BackendDiscount", new { area = "Backend" });
            }
            else
            {
                int a;
                bool check = int.TryParse(id.ToString(), out a);
                if (check == true)
                {
                    var model = JsonConvert.DeserializeObject<List<Discount>>(server.FE_FindDiscountByDiscount_id(a.ToString()));
                    if (model == null)
                    {
                        return RedirectToAction("List", "BackendDiscount", new { area = "Backend" });
                    }
                    else
                    {
                        ViewData["acc"] = model;
                        return View();
                    }
                }
                else
                {
                    return RedirectToAction("List", "BackendDiscount", new { area = "Backend" });
                }
            }
        }

        [HttpPost]
        public ActionResult EditDiscount(Discount acc)
        {
            id_old = acc.Discount_id;
            string json = JsonConvert.SerializeObject(acc);
            server.BE_EditDiscount(json, id_old);
            return RedirectToAction("List", "BackendDiscount", new { area = "Backend" });
        }
        public ActionResult Add()
        {
            return View();
        }
        public ActionResult AddDiscount(Discount acc)
        {
            string json = JsonConvert.SerializeObject(acc);
            server.BE_AddDiscount(json);
            return RedirectToAction("List", "BackendDiscount", new { area = "Backend" });
        }

        public ActionResult List()
        {
            List<Discount> listDiscount = new List<Discount>();
            listDiscount = JsonConvert.DeserializeObject<List<Discount>>(server.BE_GetListDiscount());
            return View(listDiscount);
        }

        public ActionResult DeleteDiscount(string id)
        {
            if (id == null)
            {
                return RedirectToAction("List", "BackendDiscount", new { area = "Backend" });
            }
            else
            {
                int a;
                bool check = int.TryParse(id.ToString(), out a);
                if (check == true)
                {
                    var result = server.FE_FindDiscountByDiscount_id(a.ToString());
                    if (result == null)
                    {
                        return RedirectToAction("List", "BackendDiscount", new { area = "Backend" });
                    }
                    else
                    {
                        server.FE_DeleteDiscount(id);
                        return RedirectToAction("List", "BackendDiscount", new { area = "Backend" });
                    }
                }
            }
            return View();
        }
    }
}