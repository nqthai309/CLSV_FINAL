using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CNW_N8_MVC.Class;
using CNW_N8_MVC.Entites;
using Newtonsoft.Json;
using PagedList;

namespace CNW_N8_MVC.Controllers
{
    public class Hotel2Controller : Controller
    {
        static string hotelNameSearch;
        static string star;
        static string location;
        static string limitPeople;
        static string priceSelect;
        static int hotel_ID;
        static int hotel_rooms_ID;
        static string hotel_Name;
        static string address_Detail;
        static string message_listRoom;
        static List<ItemHotel> currentListHotel = HomeController.htList;
        static List<ItemListRoom> currentListRoom;
        static List<String> serviceSelect = new List<string>();
        static List<String> convenientSelect = new List<string>();
        List<ItemHistoryOrder> listHistory = new List<ItemHistoryOrder>();
        static List<ItemHotelService> listServiceByHotel;

        static Server.ServerSoapClient server = new Server.ServerSoapClient();
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
        // GET: Hotel2
        public ActionResult ListHotel(int? page, string location_name)
        {
            if (page == null) page = 1;
            int pageSize = 9;
            int pageNumber = (page ?? 1);
            setUsername();
            if(location_name != null)
            {
                location = location_name;
                foreach(var it in currentListHotel.ToList())
                {
                    if(it.Address != location_name)
                    {
                        currentListHotel.Remove(it);
                    }
                }
            }
            var serviceList = JsonConvert.DeserializeObject<List<ItemService>>(server.FE_GetService());
            var convenientList = JsonConvert.DeserializeObject<List<ItemConvenient>>(server.FE_GetConvenient());
            var htList = currentListHotel.OrderBy(ht => ht.HotelID).ToList();
            var locList = HomeController.locList;
            ViewData["serviceList"] = serviceList;
            ViewData["convenientList"] = convenientList;
            ViewData["locList"] = locList;
            ViewData["htList"] = htList.ToPagedList(pageNumber, pageSize);

            ViewData["hotelNameSearch"] = hotelNameSearch;
            ViewData["star"] = star;
            ViewData["location"] = location;
            ViewData["serviceSelect"] = serviceSelect;
            ViewData["convenientSelect"] = convenientSelect;

            return View();
        }

        [HttpGet]
        public ActionResult SearchEngine()
        {
            var serviceList = JsonConvert.DeserializeObject<List<ItemService>>(server.FE_GetService());
            var convenientList = JsonConvert.DeserializeObject<List<ItemConvenient>>(server.FE_GetConvenient());

            serviceSelect.Clear();
            convenientSelect.Clear();
            foreach (ItemService it in serviceList)
            {
                var name = "service+" + it.Service_id.ToString();
                if(Request[name] != null)
                {
                    serviceSelect.Add(it.Service_id.ToString());
                }  
            }

            foreach (ItemConvenient it in convenientList)
            {
                var name = "convenient+" + it.Convenient_id.ToString();
                if (Request[name] != null)
                {
                    convenientSelect.Add(it.Convenient_id.ToString());
                }
            }

            hotelNameSearch = Request["hotelNameSearch"].ToString();
            star = Request["selectStar"].ToString();
            location = Request["selectLocation"].ToString();
            var htList = JsonConvert.DeserializeObject<List<ItemHotel>>(server.FE_Search_HotelList(location, hotelNameSearch, star));
            foreach (var it in htList.ToList())
            {
                if (it.MinPrice == 0 || it.MaxPrice == 0)
                {
                    htList.Remove(it);
                }
            }
            currentListHotel = htList;

            if(serviceSelect.Count() > 0 || convenientSelect.Count() > 0)
            {
                string sv_select = "";
                string conv_select = "";
                foreach(var it in serviceSelect)
                {
                    sv_select += it.ToString();
                    if(it != serviceSelect[serviceSelect.Count() - 1])
                    {
                        sv_select += ",";
                    }
                }
                foreach (var it in convenientSelect)
                {
                    conv_select += it.ToString();
                    if (it != convenientSelect[convenientSelect.Count() - 1])
                    {
                        conv_select += ",";
                    }
                }
                var result = JsonConvert.DeserializeObject<List<String>>(server.FE_Search_Hotel_Service_Convenient(sv_select, conv_select));
                foreach(var it in currentListHotel.ToList())
                {
                    if (!(result.Contains(it.HotelID.ToString())))
                    {
                        currentListHotel.Remove(it);
                    }
                }
            }

            return RedirectToAction("ListHotel");
        }
        public ActionResult ListRoom(int? page, int hotel_id)
        {
            if (page == null) page = 1;
            int pageSize = 9;
            int pageNumber = (page ?? 1);
            setUsername();
            convenientSelect.Clear();
            List<ItemListRoom> rooms;
            if(hotel_id != hotel_ID)
            {
                rooms = JsonConvert.DeserializeObject<List<ItemListRoom>>(server.FE_GetListRoom(hotel_id));
                currentListRoom = rooms;
            }
            else
            {
                rooms = currentListRoom;
            }

            hotel_ID = hotel_id;
            


            var current_hotel = HomeController.htList_backup.Where(ht => ht.HotelID == hotel_id).SingleOrDefault();
            var convenientList = JsonConvert.DeserializeObject<List<ItemConvenient>>(server.FE_GetConvenient());
            var roomList = rooms.OrderBy(r => r.Hotel_id).ToList();
            var commentList = JsonConvert.DeserializeObject<List<ItemComment>>(server.FE_GetComment(hotel_id));
            int min_people = roomList.Min(r => r.Limit_people);
            int max_people = roomList.Max(r => r.Limit_people);

            ViewData["rooms"] = roomList.ToPagedList(pageNumber, pageSize);
            ViewData["current_hotel"] = current_hotel;
            ViewData["convenientList"] = convenientList;
            ViewData["min_people"] = min_people;
            ViewData["max_people"] = max_people;
            ViewData["commentList"] = commentList;
            ViewData["limitPeople"] = limitPeople;
            ViewData["priceSelect"] = priceSelect;
            ViewData["convenientSelect"] = convenientSelect;
            ViewData["idAccount"] = UserController.idAccount.ToString();
            ViewData["message"] = message_listRoom;



            return View();
        }
        [HttpGet]
        public ActionResult SearchEngine_Room()
        {
            var convenientList = JsonConvert.DeserializeObject<List<ItemConvenient>>(server.FE_GetConvenient());
            convenientSelect.Clear();
            foreach(var it in convenientList)
            {
                var name = "convenient+" + it.Convenient_id.ToString();
                if (Request[name] != null)
                {
                    convenientSelect.Add(it.Convenient_id.ToString());
                }
            }
            limitPeople = Request["limitPeopleSelect"];
            char[] data = limitPeople.ToCharArray();
            priceSelect = Request["priceSelect"];
            var rooms = JsonConvert.DeserializeObject<List<ItemListRoom>>(server.FE_Search_Room(hotel_ID, int.Parse(data[0].ToString()), int.Parse(priceSelect)));
            currentListRoom = rooms;

            if(convenientSelect.Count() > 0)
            {
                string conv_select = "";
                foreach(var it in convenientSelect)
                {
                    conv_select += it.ToString();
                    if (it != convenientSelect[convenientSelect.Count() - 1])
                    {
                        conv_select += ",";
                    }
                }
                var result = JsonConvert.DeserializeObject<List<String>>(server.FE_Search_Room_Conv(conv_select, hotel_ID));
                foreach(var it in currentListRoom.ToList())
                {
                    if (!(result.Contains(it.Hotel_rooms_id.ToString()))){
                        currentListRoom.Remove(it);
                    }
                }
            }
            return RedirectToAction("ListRoom", new { @hotel_id = hotel_ID});
        }

        public ActionResult DetailRoom(int hotel_rooms_id)
        {
            hotel_rooms_ID = hotel_rooms_id;
            var roomDetail = currentListRoom.Where(r => r.Hotel_rooms_id == hotel_rooms_id).SingleOrDefault();
            var hotelName = currentListHotel.Where(ht => ht.HotelID == roomDetail.Hotel_id).Select(ht => ht.HotelName).SingleOrDefault();
            var listConv = JsonConvert.DeserializeObject<List<ItemHotelConvenient>>(server.FE_Get_Conv_By_hotelID_roomID(roomDetail.Hotel_id, roomDetail.Hotel_rooms_id));
            var room_other = currentListRoom.Where(r => r.Hotel_rooms_id != hotel_rooms_id).ToList();
            var address = currentListHotel.Where(ht => ht.HotelID == roomDetail.Hotel_id).Select(ht => ht.Address).SingleOrDefault();
            var addressDetail = currentListHotel.Where(ht => ht.HotelID == roomDetail.Hotel_id).Select(ht => ht.AddressDetail).SingleOrDefault();
            listServiceByHotel = JsonConvert.DeserializeObject<List<ItemHotelService>>(server.FE_Get_Service_by_HotelID(roomDetail.Hotel_id));
            listHistory = JsonConvert.DeserializeObject<List<ItemHistoryOrder>>(server.FE_GetHistoryOrderOfRoom(roomDetail.Hotel_id, roomDetail.Hotel_rooms_id));
            var hotline = server.FE_Get_hotline(roomDetail.Hotel_id);
            hotel_Name = hotelName;
            address_Detail = addressDetail;


            foreach(var it in listHistory.ToList())
            {
                DateTime from_date = Convert.ToDateTime(it.From_date);
                DateTime to_date = Convert.ToDateTime(it.To_date);
                DateTime today = DateTime.Today;
                if(today > from_date)
                {
                    listHistory.Remove(it);
                }
                
            }


            ViewData["hotline"] = hotline;
            ViewData["listHistory"] = listHistory;
            ViewData["listService"] = listServiceByHotel;
            ViewData["listConv"] = listConv;
            ViewData["hotelName"] = hotelName;
            ViewData["roomDetail"] = roomDetail;
            ViewData["room_other"] = room_other;
            ViewData["address"] = address;
            ViewData["addressDetail"] = addressDetail;

            return View();
        }


        public ActionResult DetailHotel(int hotel_id)
        {
            setUsername();
            convenientSelect.Clear();
            var list_hotel = currentListHotel;
            var current_hotel = currentListHotel.Where(ht => ht.HotelID == hotel_id).SingleOrDefault();
            var convenientList = JsonConvert.DeserializeObject<List<ItemConvenient>>(server.FE_GetConvenient());
            var roomList = JsonConvert.DeserializeObject<List<ItemListRoom>>(server.FE_GetListRoom(hotel_id));
            var commentList = JsonConvert.DeserializeObject<List<ItemComment>>(server.FE_GetComment(hotel_id));
            int min_people = roomList.Min(r => r.Limit_people);
            int max_people = roomList.Max(r => r.Limit_people);
            listServiceByHotel = JsonConvert.DeserializeObject<List<ItemHotelService>>(server.FE_Get_Service_by_HotelID(hotel_id));
            ViewData["listService"] = listServiceByHotel;
            ViewData["rooms"] = roomList;
            ViewData["current_hotel"] = current_hotel;
            ViewData["convenientList"] = convenientList;
            ViewData["hotelList"] = list_hotel;
            ViewData["min_people"] = min_people;
            ViewData["max_people"] = max_people;
            ViewData["commentList"] = commentList;
            ViewData["limitPeople"] = limitPeople;
            ViewData["priceSelect"] = priceSelect;
            ViewData["convenientSelect"] = convenientSelect;
            ViewData["idAccount"] = UserController.idAccount.ToString();
            ViewData["message"] = message_listRoom;
            ViewData["hotline"] = server.FE_Get_hotline(current_hotel.HotelID);

            return View();
        }

        public int checkDate(string checkin, string checkout)
        {
            var history = JsonConvert.DeserializeObject<List<ItemHistoryOrder>>(server.FE_GetHistoryOrderOfRoom(hotel_ID, hotel_rooms_ID));
            if (checkin == "" || checkout == "")
            {
                return -1;
            }
            else
            {
                DateTime checkIn = Convert.ToDateTime(checkin);
                DateTime checkOut = Convert.ToDateTime(checkout);
                DateTime today = DateTime.Now;
                if (checkOut <= checkIn || (checkIn <= today || checkOut <= today) || (checkIn <= today && checkOut <= today))
                {
                    return -1;
                }
                else
                {
                    if(history.Count != 0)
                    {
                        foreach(var it in history)
                        {
                            var c_in = Convert.ToDateTime(it.From_date);
                            var c_out = Convert.ToDateTime(it.To_date);
                            if(!(checkIn > c_out || checkOut < c_in))
                            {
                                return -1;
                            }
                        }
                        return 1;
                    }
                    else
                    {
                        return 1;
                    }
                    
                }

            }

        }

        [HttpGet]
        public ActionResult Order()
        {
            if(Session["Login"] == null)
            {
                return RedirectToAction("Login", "User");
            }
            else
            {
                DateTime from_date = Convert.ToDateTime(Request["from_date"]);
                DateTime to_date = Convert.ToDateTime(Request["to_date"]);
                string list_service = "";
                float totalPriceService = 0;
                foreach (var it in listServiceByHotel)
                {
                    var x = Request["madichvu+" + it.Service_id.ToString()];
                    if (x == "1")
                    {
                        list_service += it.Service_name + ',';
                        totalPriceService += it.Unit_price;
                    }
                }
                TimeSpan t = to_date - from_date;
                float quantity = (float)t.TotalDays;
                float discount_value = UserController.discount_value;
                float sell_price = (float)currentListRoom.Where(lt => lt.Hotel_id == hotel_ID & lt.Hotel_rooms_id == hotel_rooms_ID).Select(lt => lt.Sell_price).SingleOrDefault();
                float totalPrice = totalPriceService + (quantity * sell_price);
                totalPrice = totalPrice - (totalPrice * discount_value / 100);

                var newProduct = new Product();
                newProduct.Hotel_id = hotel_ID;
                newProduct.Hotel_rooms_id = hotel_rooms_ID;
                newProduct.HotelName = hotel_Name;
                newProduct.AddressDetail = address_Detail;
                newProduct.From_date = from_date.ToString().Split(' ')[0];
                newProduct.To_date = to_date.ToString().Split(' ')[0];
                newProduct.Service_list = list_service;
                newProduct.TotalPriceService = totalPriceService;
                newProduct.TotalPrice = totalPrice;
                var cart = (Cart)Session["CartSession"];
                if(cart != null)
                {
                    cart.AddItemHotel(newProduct);
                }
                else
                {
                    cart = new Cart();
                    cart.AddItemHotel(newProduct);
                    Session["CartSession"] = cart;
                }
                return RedirectToAction("Booking", "User");
            }
            
        }
        [HttpPost]
        public ActionResult SendComment()
        {
            var cmt = Request["contentComment"];
            var acc = (Users)Session["Login"];
            if(cmt == "" || acc == null)
            {
                //message_listRoom = "Ban phai dang nhap de binh luan";
                return RedirectToAction("ListRoom", "Hotel2", new { @hotel_id = hotel_ID });
            }
            else
            {
                var respone = server.FE_SendComment(UserController.idAccount.ToString(), hotel_ID, cmt);
                if (respone == "-1")
                {
                    //message_listRoom = "Chua dien noi dung binh luan";
                    return RedirectToAction("ListRoom", "Hotel2", new { @hotel_id = hotel_ID });
                }
                else
                {
                    //message_listRoom = "Cam on ban da binh luan";
                    return RedirectToAction("ListRoom", "Hotel2", new { @hotel_id = hotel_ID });
                }
            }
            
        }
    }
}