using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CNW_N8_MVC.Class
{
    public class ItemHotelService
    {
        int hotel_id;
        int service_id;
        float unit_price;
        string service_image;
        string service_name;

        public int Hotel_id { get => hotel_id; set => hotel_id = value; }
        public int Service_id { get => service_id; set => service_id = value; }
        public float Unit_price { get => unit_price; set => unit_price = value; }
        public string Service_image { get => service_image; set => service_image = value; }
        public string Service_name { get => service_name; set => service_name = value; }
    }
}