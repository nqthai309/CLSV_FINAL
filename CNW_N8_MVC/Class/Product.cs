using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CNW_N8_MVC.Class
{
    public class Product
    {
        string hotelName;
        string addressDetail;
        int hotel_id;
        int hotel_rooms_id;
        string from_date;
        string to_date;
        string service_list;
        float totalPriceService;
        float totalPrice;

        public string HotelName { get => hotelName; set => hotelName = value; }
        public string AddressDetail { get => addressDetail; set => addressDetail = value; }
        public int Hotel_id { get => hotel_id; set => hotel_id = value; }
        public int Hotel_rooms_id { get => hotel_rooms_id; set => hotel_rooms_id = value; }
        public string From_date { get => from_date; set => from_date = value; }
        public string To_date { get => to_date; set => to_date = value; }
        public string Service_list { get => service_list; set => service_list = value; }
        public float TotalPriceService { get => totalPriceService; set => totalPriceService = value; }
        public float TotalPrice { get => totalPrice; set => totalPrice = value; }
    }
}