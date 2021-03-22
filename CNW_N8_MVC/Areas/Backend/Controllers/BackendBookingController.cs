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
        //static List<ItemBooking> bks = JsonConvert.DeserializeObject<List<ItemBooking>>(server.GetListBooking_BE());
        static List<ItemBooking> list_bk = new List<ItemBooking>();
        public ActionResult List()
        {
            //var bookings = JsonConvert.DeserializeObject<List<ItemBooking>>(server.GetListBooking_BE());
            List<ItemBooking> bks = JsonConvert.DeserializeObject<List<ItemBooking>>(server.GetListBooking_BE());
            ViewData["bookings"] = bks.OrderByDescending(l => l.BookingRoot.Time_booking);
            ViewData["list_bk"] = list_bk.OrderByDescending(l => l.BookingRoot.Time_booking);
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
        public ActionResult ChangeStatus()
        {
            List<ItemBooking> bks = JsonConvert.DeserializeObject<List<ItemBooking>>(server.GetListBooking_BE());
            var status = Request["status"];
            list_bk.Clear();
            if(status == "1")
            {
                //da hoan thanh
                foreach(var it in bks)
                {
                    if(it.BookingRoot.Payment_status == "Đã hoàn thành")
                    {
                        list_bk.Add(it);
                    }
                }
            }
            else
            {
                foreach (var it in bks)
                {
                    if (it.BookingRoot.Payment_status == "Đang xử lý")
                    {
                        list_bk.Add(it);
                    }
                }
            }
            return RedirectToAction("List", "BackendBooking", new { area = "Backend" });
        }
    }
}