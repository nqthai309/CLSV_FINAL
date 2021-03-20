using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CNW_N8_MVC.Class
{
    public class ItemService
    {
        int service_id;
        string service_name;
        string service_image;

        public int Service_id { get => service_id; set => service_id = value; }
        public string Service_name { get => service_name; set => service_name = value; }
        public string Service_image { get => service_image; set => service_image = value; }
    }
}