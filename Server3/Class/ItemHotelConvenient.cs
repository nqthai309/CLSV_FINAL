using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Server3.Class
{
    public class ItemHotelConvenient
    {
        int hotel_id;
        int hotel_rooms_id;
        int convenient_id;
        string convenient_name;
        string convenient_image;

        public int Hotel_id { get => hotel_id; set => hotel_id = value; }
        public int Hotel_rooms_id { get => hotel_rooms_id; set => hotel_rooms_id = value; }
        public int Convenient_id { get => convenient_id; set => convenient_id = value; }
        public string Convenient_name { get => convenient_name; set => convenient_name = value; }
        public string Convenient_image { get => convenient_image; set => convenient_image = value; }
    }
}