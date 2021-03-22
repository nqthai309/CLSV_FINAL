using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using CNW_N8_MVC.Class;

namespace CNW_N8_MVC.Areas.Backend.Controllers
{
    public class BackendHotelRoomController : Controller
    {
        // GET: Backend/BackendHotelRoom
        static Server.ServerSoapClient server = new Server.ServerSoapClient();
        static List<BE_ItemHotelRoom> list_room = new List<BE_ItemHotelRoom>();
        static string name_search = "";
        
        public ActionResult Edit(int hotel_id, int hotel_rooms_id)
        {
            List<BE_ItemHotelRoom> list = JsonConvert.DeserializeObject<List<BE_ItemHotelRoom>>(server.BE_GetListHotelRoom());
            var hr = list.Where(l => l.Hotel_id == hotel_id && l.Hotel_rooms_id == hotel_rooms_id).FirstOrDefault();
            ViewData["hr"] = hr;
            return View("Edit");
        }

        [HttpPost]
        public ActionResult EditHotelRoom(BE_ItemHotelRoom hr){

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

            var result = server.BE_EditHotelRoom(JsonConvert.SerializeObject(hr));
            if(result == "1")
            {
                return RedirectToAction("List", "BackendHotelRoom", new { area = "Backend" });
            }
            else
            {
                return RedirectToAction("List", "BackendHotelRoom", new { area = "Backend" });
            }
            
        }
        public ActionResult DeleteHotelRoom(int hotel_id, int hotel_rooms_id)
        {
            string result = server.BE_DeleteHotelRoom(hotel_rooms_id);
            if(result == "1")
            {
                return RedirectToAction("List", "BackendHotelRoom", new { area = "Backend" });
            }
            else
            {
                return RedirectToAction("List", "BackendHotelRoom", new { area = "Backend" });
            }
        }

        public ActionResult List()
        {
            List<BE_ItemHotelRoom> list = JsonConvert.DeserializeObject<List<BE_ItemHotelRoom>>(server.BE_GetListHotelRoom());
            ViewData["list"] = list;
            ViewData["list_room"] = list_room;
            ViewData["name_search"] = name_search;
            return View();
        }
        public ActionResult SearchName()
        {
            list_room.Clear();
            var search = Request["name_search"];
            name_search = search;
            List<BE_ItemHotelRoom> list = JsonConvert.DeserializeObject<List<BE_ItemHotelRoom>>(server.BE_GetListHotelRoom());
            foreach(var it in list)
            {
                if (it.Hotel_name.ToLower().Contains(search.ToLower()))
                {
                    list_room.Add(it);
                }
            }
            return RedirectToAction("List", "BackendHotelRoom", new { area = "Backend" });
        }
    }
}