using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CNW_N8_MVC.Class
{
    public class ItemHistoryOrder
    {
        string from_date;
        string to_date;

        public string From_date { get => from_date; set => from_date = value; }
        public string To_date { get => to_date; set => to_date = value; }
    }
}