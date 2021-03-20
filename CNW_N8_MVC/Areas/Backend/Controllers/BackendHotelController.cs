using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Dynamic;

using CNW_N8_MVC.Models;
using CNW_N8_MVC.Class;
using Newtonsoft.Json;

namespace CNW_N8_MVC.Areas.Backend.Controllers
{
    public class BackendHotelController : BaseController
    {
        static ServiceReference1.WebService1SoapClient client = new ServiceReference1.WebService1SoapClient();
        private Model1 context = new Model1();
        static int id_Old;
        //static Server.ServerSoapClient server = new Server.ServerSoapClient();
        static Server.ServerSoapClient server = new Server.ServerSoapClient();
        public static List<ItemLocation> locList = JsonConvert.DeserializeObject<List<ItemLocation>>(server.FE_GetListLocation());
        static List<BE_ItemHotel> currentHotel;

        // GET: BackendHotel
        public ActionResult AddHotelRoom(int? id)
        {
            ViewData["hotel_id"] = id.ToString();
            return View();
        }
        [HttpPost]
        public ActionResult AddHotelRoomCenter(BE_ItemHotelRoom hr)
        {
            if (hr.Detail_header_image_url_1.Contains("\\\\"))
            {
                string[] data = hr.Detail_header_image_url_1.Split(new string[] { "\\\\" }, StringSplitOptions.None);
                hr.Detail_header_image_url_1 = data[0] + "\\" + data[1];
            }
            if (hr.Detail_header_image_url_2.Contains("\\\\"))
            {
                string[] data = hr.Detail_header_image_url_2.Split(new string[] { "\\\\" }, StringSplitOptions.None);
                hr.Detail_header_image_url_2 = data[0] + "\\" + data[1];
            }
            if (hr.Detail_header_image_url_3.Contains("\\\\"))
            {
                string[] data = hr.Detail_header_image_url_3.Split(new string[] { "\\\\" }, StringSplitOptions.None);
                hr.Detail_header_image_url_3 = data[0] + "\\" + data[1];
            }
            if (hr.Detail_header_image_url_4.Contains("\\\\"))
            {
                string[] data = hr.Detail_header_image_url_4.Split(new string[] { "\\\\" }, StringSplitOptions.None);
                hr.Detail_header_image_url_4 = data[0] + "\\" + data[1];
            }
            string result = server.BE_AddHotelRoom(JsonConvert.SerializeObject(hr));
            if(result == "1")
            {
                return RedirectToAction("List", "BackendHotel", new { area = "Backend" });
            }
            else
            {
                return RedirectToAction("List", "BackendHotel", new { area = "Backend" });
            }
        }
        public ActionResult List()
        {
            var hotels = JsonConvert.DeserializeObject<List<BE_ItemHotel>>(server.BE_GetListHotel());
            currentHotel = hotels;
            ViewData["hotels"] = hotels;
            return View();
        }

        public ActionResult Add()
        {
            dynamic model = new ExpandoObject();
            model.itemLocations = locList;
            model.listService = JsonConvert.DeserializeObject<List<ItemService>>(server.FE_GetService());
            return View(model);
        }

        public ActionResult Edit(string hotel_id)
        {
            var hotel = currentHotel.Where(ht => ht.Hotel_id == int.Parse(hotel_id)).SingleOrDefault();
            ViewData["hotel"] = hotel;
            ViewData["locList"] = locList;
            return View();

        }
        public int checkAddHotel(string location_id, string hotel_name, string description, string more_imformation, string price, string sell_price)
        {
            if (location_id == "" || hotel_name == "")
            {
                return -1;
            }
            return 1;
        }
        [HttpPost]
        public ActionResult AddHotel(hotels hotel)
        {
            var services = Request["test"];

            return RedirectToAction("List", "BackendHotel", new { area = "Backend" });
        }

        [HttpPost]
        public ActionResult AddHotelJS(string[] arrService, int location_id, string hotel_name, string image_url, string description, string hotel_hotline, string location_details, int star)
        {
            string service_name = "";
            string unit_price = "";

            string[] data = image_url.Split(new string[] { "\\\\" }, StringSplitOptions.None);
            image_url = data[0] + "\\" + data[1];

            foreach (var it in arrService)
            {
                if(it != arrService[arrService.Count() - 1])
                {
                    service_name += (it.Split('-')[0]) + ',';
                    unit_price += (it.Split('-')[1]) + ',';
                }
                else
                {
                    service_name += (it.Split('-')[0]);
                    unit_price += (it.Split('-')[1]);
                }
                
            }
            var newHotel = new BE_ItemHotel();
            newHotel.Location_id = location_id;
            newHotel.Hotel_name = hotel_name;
            newHotel.Image_url = image_url;
            newHotel.Description = description;
            newHotel.Hotel_hotline = hotel_hotline;
            newHotel.Location_details = location_details;
            newHotel.Detail_header_image_url = image_url;
            newHotel.Star = star;

            string json = JsonConvert.SerializeObject(newHotel);
            string result = server.BE_AddHotel(json, service_name, unit_price);
            if(result == "1")
            {
                return RedirectToAction("List", "BackendHotel", new { area = "Backend" }); ;
            }
            else
            {
                return RedirectToAction("List", "BackendHotel", new { area = "Backend" }); ;
            }

            
        }

        [HttpPost]
        public ActionResult EditHotel(BE_ItemHotel hotel)
        {
            hotel.Detail_header_image_url = hotel.Image_url;
            var result = server.BE_EditHotel(JsonConvert.SerializeObject(hotel));
            if(result == "1")
            {
                return RedirectToAction("List", "BackendHotel", new { area = "Backend" });
            }
            else
            {
                return RedirectToAction("List", "BackendHotel", new { area = "Backend" });
            }
            
        }


        public ActionResult DeleteHotel(string id)
        {
            var result = server.BE_DeleteHotel(int.Parse(id));
            if(result == "1")
            {
                return RedirectToAction("List", "BackendHotel", new { area = "Backend" });
            }
            else
            {
                return RedirectToAction("List", "BackendHotel", new { area = "Backend" });
            }

        }

        public int checkEditHotel(string location_id, string hotel_name, string description, string more_imformation, string price, string sell_price)
        {
            if (location_id == "" || hotel_name == "" || description == "" || more_imformation == "" || price == "" || sell_price == "")
            {
                return -1;
            }
            else
            {
                var result = context.hotels.Where(h => h.hotel_name == hotel_name).FirstOrDefault();
                var hotel_old = context.hotels.Find(id_Old);

                if (result == null || hotel_old.hotel_name == hotel_name)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}