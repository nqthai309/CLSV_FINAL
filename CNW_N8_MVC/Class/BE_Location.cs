using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CNW_N8_MVC.Class
{
    public class BE_Location
    {
        int location_id;
        string location_name;
        string image_url;

        public string Location_name { get => location_name; set => location_name = value; }
        public string Image_url { get => image_url; set => image_url = value; }
        public int Location_id { get => location_id; set => location_id = value; }
    }
}