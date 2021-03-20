using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CNW_N8_MVC.Class
{
    public class ItemBanners
    {
        int banner_id;
        string banner_image;

        public int Banner_id { get => banner_id; set => banner_id = value; }
        public string Banner_image { get => banner_image; set => banner_image = value; }
    }
}