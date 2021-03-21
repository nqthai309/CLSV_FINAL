using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CNW_N8_MVC.Class
{
    public class BE_HistoryBooking
    {
        string hotel_name;
        string location_details;
        int hotel_rooms_id;
        string from_date;
        string to_date;
        string service_list;
        double total_booking_price;
        string time_booking;
        string payment_status;

        public string Hotel_name { get => hotel_name; set => hotel_name = value; }
        public string Location_details { get => location_details; set => location_details = value; }
        public int Hotel_rooms_id { get => hotel_rooms_id; set => hotel_rooms_id = value; }
        public string From_date { get => from_date; set => from_date = value; }
        public string To_date { get => to_date; set => to_date = value; }
        public string Service_list { get => service_list; set => service_list = value; }
        public double Total_booking_price { get => total_booking_price; set => total_booking_price = value; }
        public string Time_booking { get => time_booking; set => time_booking = value; }
        public string Payment_status { get => payment_status; set => payment_status = value; }
    }
}