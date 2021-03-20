using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Server3.Class
{
    public class ItemBooking
    {
        ItemBookingRoot bookingRoot;
        List<ItemBookingDetail> listDetail;

        public ItemBooking(ItemBookingRoot bookingRoot, List<ItemBookingDetail> listDetail)
        {
            this.bookingRoot = bookingRoot;
            this.listDetail = listDetail;
        }

        public ItemBookingRoot BookingRoot { get => bookingRoot; set => bookingRoot = value; }
        public List<ItemBookingDetail> ListDetail { get => listDetail; set => listDetail = value; }
    }
}