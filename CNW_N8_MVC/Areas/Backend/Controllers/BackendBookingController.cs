using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Dynamic;
using CNW_N8_MVC.Class;
using Newtonsoft.Json;

namespace CNW_N8_MVC.Areas.Backend.Controllers
{
    public class BackendBookingController : BaseController
    {
        // GET: BackendBooking
        //private Model1 context = new Model1();
        // static ServiceReference1.WebService1SoapClient client = new ServiceReference1.WebService1SoapClient();
        static Server.ServerSoapClient server = new Server.ServerSoapClient();
        public ActionResult List()
        {
            var bookings = JsonConvert.DeserializeObject<List<ItemBooking>>(server.GetListBooking_BE());
            ViewData["bookings"] = bookings;
            return View();
        }

        public ActionResult ConfirmHotelBooking(int id)
        {
            server.ConfirmHotelBooking_BE(id);
            return RedirectToAction("List", "BackendBooking", new { area = "Backend" });
        }

        public ActionResult DeleteHotelBooking(int id)
        {
            server.DeleteHotelBooking_BE(id);
            return RedirectToAction("List", "BackendBooking", new { area = "Backend" });
        }
    }
}