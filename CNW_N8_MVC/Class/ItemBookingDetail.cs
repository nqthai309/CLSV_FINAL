using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CNW_N8_MVC.Class
{
    public class ItemBookingDetail
    {
        int booking_detail_id;
        int booking_id;
        string hotel_name;
        int hotel_rooms_id;
        string from_date;
        string to_date;
        double total_price;
        string service_list;
        double total_services_price;

        public int Booking_detail_id { get => booking_detail_id; set => booking_detail_id = value; }
        public int Booking_id { get => booking_id; set => booking_id = value; }
        public string Hotel_name { get => hotel_name; set => hotel_name = value; }
        public int Hotel_rooms_id { get => hotel_rooms_id; set => hotel_rooms_id = value; }
        public string From_date { get => from_date; set => from_date = value; }
        public string To_date { get => to_date; set => to_date = value; }
        public double Total_price { get => total_price; set => total_price = value; }
        public string Service_list { get => service_list; set => service_list = value; }
        public double Total_services_price { get => total_services_price; set => total_services_price = value; }

    }
}