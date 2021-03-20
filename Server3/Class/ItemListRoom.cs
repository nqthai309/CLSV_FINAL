using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Server3.Class
{
    public class ItemListRoom
    {
        int hotel_rooms_id;
        int hotel_id;
        string detail_header_image_url_1;
        string detail_header_image_url_2;
        string detail_header_image_url_3;
        string detail_header_image_url_4;
        double acreage;
        int floors;
        int limit_people;
        int bed_count;
        double price;
        double sell_price;

        public int Hotel_rooms_id { get => hotel_rooms_id; set => hotel_rooms_id = value; }
        public int Hotel_id { get => hotel_id; set => hotel_id = value; }
        public string Detail_header_image_url_1 { get => detail_header_image_url_1; set => detail_header_image_url_1 = value; }
        public string Detail_header_image_url_2 { get => detail_header_image_url_2; set => detail_header_image_url_2 = value; }
        public string Detail_header_image_url_3 { get => detail_header_image_url_3; set => detail_header_image_url_3 = value; }
        public string Detail_header_image_url_4 { get => detail_header_image_url_4; set => detail_header_image_url_4 = value; }
        public double Acreage { get => acreage; set => acreage = value; }
        public int Floors { get => floors; set => floors = value; }
        public int Limit_people { get => limit_people; set => limit_people = value; }
        public int Bed_count { get => bed_count; set => bed_count = value; }
        public double Price { get => price; set => price = value; }
        public double Sell_price { get => sell_price; set => sell_price = value; }
    }
}