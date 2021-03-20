using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CNW_N8_MVC.Class
{
    public class BE_ItemHotel
    {
        int hotel_id;
        string location_name;
        int location_id;
        string hotel_name;
        string image_url;
        int star;
        string detail_header_image_url;
        string description;
        string hotel_hotline;
        string location_details;
        int booking_count;

        public int Hotel_id { get => hotel_id; set => hotel_id = value; }
        public string Location_name { get => location_name; set => location_name = value; }
        public int Location_id { get => location_id; set => location_id = value; }
        public string Hotel_name { get => hotel_name; set => hotel_name = value; }
        public string Image_url { get => image_url; set => image_url = value; }
        public int Star { get => star; set => star = value; }
        public string Detail_header_image_url { get => detail_header_image_url; set => detail_header_image_url = value; }
        public string Description { get => description; set => description = value; }
        public string Hotel_hotline { get => hotel_hotline; set => hotel_hotline = value; }
        public string Location_details { get => location_details; set => location_details = value; }
        public int Booking_count { get => booking_count; set => booking_count = value; }

    }
}