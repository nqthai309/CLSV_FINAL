using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CNW_N8_MVC.Class
{
    public class Discount
    {
        string discount_id;
        double discount_value;

        public string Discount_id { get => discount_id; set => discount_id = value; }
        public double Discount_value { get => discount_value; set => discount_value = value; }
    }
}