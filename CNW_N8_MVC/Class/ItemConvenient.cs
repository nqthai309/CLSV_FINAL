using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CNW_N8_MVC.Class
{
    public class ItemConvenient
    {
        int convenient_id;
        string convenient_name;
        string convenient_image;

        public int Convenient_id { get => convenient_id; set => convenient_id = value; }
        public string Convenient_name { get => convenient_name; set => convenient_name = value; }
        public string Convenient_image { get => convenient_image; set => convenient_image = value; }
    }
}