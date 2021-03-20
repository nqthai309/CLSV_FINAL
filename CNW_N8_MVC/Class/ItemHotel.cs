using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CNW_N8_MVC.Class
{
    public class ItemHotel
    {
        int hotelID;
        string image_url;
        string detail_header_image_url;
        string hotelName;
        int star;
        string description;
        double minPrice;
        double maxPrice;
        string address;
        string addressDetail;
        int totalComment;

        public int HotelID { get => hotelID; set => hotelID = value; }
        public string Image_url { get => image_url; set => image_url = value; }
        public string Detail_header_image_url { get => detail_header_image_url; set => detail_header_image_url = value; }
        public string HotelName { get => hotelName; set => hotelName = value; }
        public int Star { get => star; set => star = value; }
        public string Description { get => description; set => description = value; }
        public double MinPrice { get => minPrice; set => minPrice = value; }
        public double MaxPrice { get => maxPrice; set => maxPrice = value; }
        public string Address { get => address; set => address = value; }
        public string AddressDetail { get => addressDetail; set => addressDetail = value; }
        public int TotalComment { get => totalComment; set => totalComment = value; }
    }
}