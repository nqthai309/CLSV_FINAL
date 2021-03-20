using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Dynamic;
using CNW_N8_MVC.Class;
using CNW_N8_MVC.Entites;
using Newtonsoft.Json;

namespace CNW_N8_MVC.Controllers
{
    public class HomeController : Controller
    {
        //private Model1 context = new Model1();
        //static ServiceReference1.WebService1SoapClient client = new ServiceReference1.WebService1SoapClient();

        static Server.ServerSoapClient server = new Server.ServerSoapClient();
        public static List<ItemHotel> htList;
        public static List<ItemLocation> locList;
        private void setUsername()
        {
            if (Session["Login"] == null)
            {
                ViewData["username"] = null;
            }
            else
            {
                ViewData["username"] = UserController.userName;
            }
        }
        public ActionResult Index()
        {
            dynamic model = new ExpandoObject();
            htList = JsonConvert.DeserializeObject<List<ItemHotel>>(server.FE_GetHotel_OrderByComment());

            foreach(var it in htList.ToList())
            {
                if(it.MinPrice == 0 || it.MaxPrice == 0)
                {
                    htList.Remove(it);
                }
            }

            locList = JsonConvert.DeserializeObject<List<ItemLocation>>(server.FE_GetListLocation());
            model.itemHotels = htList.OrderByDescending(ht => ht.TotalComment).ToList();
            model.itemLocations = locList;
            model.banners = JsonConvert.DeserializeObject<List<ItemBanners>>(server.FE_GetBanner());
            setUsername();
            return View(model);
        }
    }
}