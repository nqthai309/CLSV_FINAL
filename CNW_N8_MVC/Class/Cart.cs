using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CNW_N8_MVC.Class;
namespace CNW_N8_MVC.Class
{
    [Serializable]
    public class CartItem
    {
        private Product product;

        public CartItem(Product product)
        {
            this.Product = product;
        }

        public Product Product { get => product; set => product = value; }
    }
    public class Cart
    {
        static List<CartItem> cartItems = new List<CartItem>();

        public void AddItemHotel(Product prod)
        {
            var item = cartItems.Where(it => it.Product.Hotel_id == prod.Hotel_id && it.Product.Hotel_rooms_id == prod.Hotel_rooms_id).SingleOrDefault();
            if (item == null)
            {
                var newItem = new CartItem(prod);
                cartItems.Add(newItem);
            }
            else
            {
                if(item.Product.From_date == prod.From_date)
                {
                    item.Product.To_date = prod.To_date;
                    item.Product.TotalPrice = prod.TotalPrice;
                    item.Product.TotalPriceService = prod.TotalPriceService;
                    item.Product.Service_list = prod.Service_list;
                }
                else if(item.Product.To_date == prod.To_date)
                {
                    item.Product.From_date = prod.From_date;
                    item.Product.TotalPrice = prod.TotalPrice;
                    item.Product.TotalPriceService = prod.TotalPriceService;
                    item.Product.Service_list = prod.Service_list;

                }
                else if(item.Product.From_date == prod.From_date && item.Product.To_date == prod.To_date)
                {
                    item.Product.Service_list = prod.Service_list;
                    item.Product.TotalPriceService = prod.TotalPriceService;
                }
                else
                {
                    var newItem = new CartItem(prod);
                    cartItems.Add(newItem);
                }
            }
        }
        public void RemoveLine(Product prod)
        {
            cartItems.RemoveAll(it => it.Product.Hotel_rooms_id == prod.Hotel_rooms_id && it.Product.Hotel_id == prod.Hotel_id && it.Product.From_date == prod.From_date);

        }
        public void Clear()
        {
            cartItems.Clear();
        }
        public IEnumerable<CartItem> lines { get { return cartItems; } }
    }
}