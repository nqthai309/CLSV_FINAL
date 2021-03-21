using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CNW_N8_MVC.Class
{
    public class BE_OrderStatistical
    {
        int booking_id;
        int user_id;
        string time_booking;
        double total_booking_price;
        string payment_status;
        string full_name;

        public int Booking_id { get => booking_id; set => booking_id = value; }
        public int User_id { get => user_id; set => user_id = value; }
        public string Time_booking { get => time_booking; set => time_booking = value; }
        public double Total_booking_price { get => total_booking_price; set => total_booking_price = value; }
        public string Payment_status { get => payment_status; set => payment_status = value; }
        public string Full_name { get => full_name; set => full_name = value; }
    }
}