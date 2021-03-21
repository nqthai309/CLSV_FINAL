using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CNW_N8_MVC.Class
{
    public class BE_TotalPriceByUser
    {
        int user_id;
        string full_name;
        string total_price;

        public int User_id { get => user_id; set => user_id = value; }
        public string Full_name { get => full_name; set => full_name = value; }
        public string Total_price { get => total_price; set => total_price = value; }
    }
}