using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Mvc;
//using CNW_N8_MVC.Models;
using CNW_N8_MVC.Entites;
using Newtonsoft.Json;
using CNW_N8_MVC.Class;

namespace CNW_N8_MVC.Controllers
{
    public class UserController : Controller
    {
        //Model1 context = new Model1();
        public static int idAccount = -1;
        public static string userName = null;
        public static float discount_value = 0;
        static string payment_status;
        //static ServiceReference1.WebService1SoapClient client = new ServiceReference1.WebService1SoapClient();
        static Server.ServerSoapClient server = new Server.ServerSoapClient();
        // GET: User

        public string EncodingPassword(string password)
        {
            MD5 mh = MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(password);
            byte[] hash = mh.ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x2"));
            }
            return sb.ToString();
        }
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult Login()
        {
            
            return View();
        }
        public ActionResult Logout()
        {
            Session["Login"] = null;
            Session["CartSession"] = null;
            idAccount = 0;
            userName = null;
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public ActionResult LoginCenter(users acc)
        {
            List<Users> result = JsonConvert.DeserializeObject<List<Users>>(server.FE_FindUserByUsername_Password(acc.username, acc.password));
            if(result.Count == 0)
            {

                return View("LoginFail");
            }
            else
            {
                
                Session["Login"] = result[0];
                idAccount = result[0].User_id;
                userName = result[0].Username.ToString();
                discount_value = (float)result[0].Discount_value;
                ViewData["username"] = result[0].Username.ToString();
                return RedirectToAction("Index", "Home");
            }

        }
        public int checkDangKy(string user, string pass)
        {
            if (user == "" || pass == "")
            {
                return -1;
            }
            else
            {
                var result = JsonConvert.DeserializeObject<String>(server.FE_isUsernameCheck(user));
                if (result == "true")
                {
                    //bi trung username khi dang ky
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        public int checkNewPassword(string nowPassword, string newPassword, string NewPassword2)
        {
            var result = JsonConvert.DeserializeObject<List<users>>(server.FE_FindUserByUser_id(idAccount.ToString()))[0];
            nowPassword = EncodingPassword(nowPassword);
            if (result.password == nowPassword && newPassword != "" && NewPassword2 != "")
            {
                if (newPassword == NewPassword2)
                {
                    return 1;
                }
            }
            return -1;
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RegisterCenter(users acc)
        {
            string x = JsonConvert.SerializeObject(acc);
            server.FE_Register(JsonConvert.SerializeObject(acc));
            return RedirectToAction("Login", "User");

        }

        public ActionResult Config()
        {
            if (Session["Login"] == null)
            {
                return View("Login");
            }
            else
            {
                var acc = JsonConvert.DeserializeObject<List<Users>>(server.FE_FindUserByUser_id(idAccount.ToString()))[0];
                //var acc = Session["Login"];
                ViewData["username"] = userName;
                //Session["Login"] = acc;
                ViewData["acc"] = acc;
                return View();
            }

        }

        public ActionResult Booking()
        {
            Cart cart;
            ViewData["username"] = userName;
            if (Session["Login"] == null)
            {
                return View("Login");
            }
            else
            {
                cart = (Cart)Session["CartSession"];
                if (cart == null)
                {
                    cart = new Cart();
                }
                return View(cart);
            }
        }

        public ActionResult BookingHistory()
        {
            var list_history = JsonConvert.DeserializeObject<List<BE_HistoryBooking>>(server.FE_GetHistoryOrder_User(idAccount));
            ViewData["list_history"] = list_history;
            return View();
        }

        [HttpPost]
        public ActionResult UserChanges(users acc)
        {
            var obj = JsonConvert.DeserializeObject<List<users>>(server.FE_FindUserByUser_id(idAccount.ToString()))[0];
            obj.full_name = acc.full_name;
            obj.phone = acc.phone;
            obj.email = acc.email;
            obj.address = acc.address;
            string json = JsonConvert.SerializeObject(obj);
            server.FE_UpdateUserInfo(idAccount.ToString(), json);
            //idAccount += 1;
            //Session["Login"] = obj;
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public ActionResult PasswordChanges(string password, string newPassword1, string newPassword2)
        {
            var obj = JsonConvert.DeserializeObject<List<users>>(server.FE_FindUserByUser_id(idAccount.ToString()))[0];
            server.FE_UpdateUserPassword(obj.user_id.ToString(), newPassword1);
            return RedirectToAction("Index", "Home");

        }

        public ActionResult RemoveLine(Product prod)
        {
            var cart = (Cart)Session["CartSession"];
            cart.RemoveLine(prod);
            return RedirectToAction("Booking", "User");
        }

        [HttpPost]
        public ActionResult Payment()
        {
            var acc = (Users)Session["Login"];
            var cart = (Cart)Session["CartSession"];
            if(acc == null || cart == null || cart.lines.Count() == 0)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                var listCartItem = cart.lines;
                var totalBookingPrice = float.Parse(Request["totalBookingPrice"].ToString().Split('=')[1]);
                payment_status = "Đang xử lý";
                var respone = server.FE_Payment(JsonConvert.SerializeObject(listCartItem), acc.User_id, totalBookingPrice, payment_status);
                if(respone == "1")
                {
                    cart.Clear();
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }
            }
        }
        //public ActionResult RemoveLine(string id,string checkin, string status_checking)
        //{
        //    int a;
        //    bool check = int.TryParse(id, out a);
        //    if(check == true)
        //    {
        //        if (status_checking == "hotel")
        //        {
        //            var result = JsonConvert.DeserializeObject<user>(client.FrontEndFindHotelById(a));
        //            var product = new Product(result.id.ToString(), "hotel", checkin);
        //            var cart = (Cart)Session["CartSession"];
        //            if(cart != null)
        //            {
        //                cart.RemoveLineProduct(product);
        //                return RedirectToAction("Booking", "User");
        //            }
        //            else
        //            {
        //                return RedirectToAction("Index", "Home");
        //            }
        //        }
        //        else if(status_checking == "homestay")
        //        {
        //            var result = JsonConvert.DeserializeObject<user>(client.FrontEndFindHomestayById(a));
        //            var product = new Product(result.id.ToString(), "homestay", checkin);
        //            var cart = (Cart)Session["CartSession"];
        //            if (cart != null)
        //            {
        //                cart.RemoveLineProduct(product);
        //                return RedirectToAction("Booking", "User");
        //            }
        //            else
        //            {
        //                return RedirectToAction("Index", "Home");
        //            }
        //        }
        //        else
        //        {
        //            return RedirectToAction("Index", "Home");
        //        }
        //    }
        //    else
        //    {
        //        return RedirectToAction("Index", "Home");
        //    }

        //}
        //[HttpPost]
        //public ActionResult ThanhToan()
        //{
        //    var cart = (Cart)Session["CartSession"];
        //    var acc = context.users.Find(idAccount);

        //    if(cart == null || cart.lines.Count() == 0 || acc == null)
        //    {
        //        return RedirectToAction("Login", "User");
        //    }
        //    else
        //    {
        //        foreach(var it in cart.lines)
        //        {
        //            if(it.Product.Status_checking == "hotel")
        //            {
        //                DateTime checkin = Convert.ToDateTime(it.Product.Checkin);
        //                DateTime checkout = Convert.ToDateTime(it.Product.Checkout);
        //                TimeSpan t = checkout - checkin;

        //                var ht_booking = new hotel_booking();
        //                ht_booking.customer_address = acc.address;
        //                ht_booking.customer_email = acc.email;
        //                ht_booking.customer_name = acc.full_name;
        //                ht_booking.customer_phone = acc.phone;
        //                ht_booking.user_id = acc.id;

        //                ht_booking.hotel_id = int.Parse(it.Product.Id);
        //                ht_booking.from_date = checkin;
        //                ht_booking.to_date = checkout;


        //                ht_booking.selectDichVu = it.SelectDichVu;
        //                ht_booking.thanhTienDichVu = it.ThanhTienDichVu;
        //                ht_booking.status_check = "Đang Xử Lý";
        //                ht_booking.total_price = ((int)t.TotalDays * int.Parse(it.Product.Sell_price));
        //                client.FrontEndAddHotelBooking(JsonConvert.SerializeObject(ht_booking));



        //            }
        //            else if(it.Product.Status_checking == "homestay")
        //            {
        //                DateTime checkin = Convert.ToDateTime(it.Product.Checkin);
        //                DateTime checkout = Convert.ToDateTime(it.Product.Checkout);
        //                TimeSpan t = checkout - checkin;

        //                var hstay_booking = new homestay_booking();
        //                hstay_booking.customer_address = acc.address;
        //                hstay_booking.customer_email = acc.email;
        //                hstay_booking.customer_name = acc.full_name;
        //                hstay_booking.customer_phone = acc.phone;
        //                hstay_booking.user_id = acc.id;

        //                hstay_booking.homestay_id = int.Parse(it.Product.Id);
        //                hstay_booking.from_date = checkin;
        //                hstay_booking.to_date = checkout;


        //                hstay_booking.selectDichVu = it.SelectDichVu;
        //                hstay_booking.thanhTienDichVu = it.ThanhTienDichVu;
        //                hstay_booking.status_check = "Đang Xử Lý";
        //                hstay_booking.total_price = ((int)t.TotalDays * int.Parse(it.Product.Sell_price));
        //                client.FrontEndAddHomestayBooking(JsonConvert.SerializeObject(hstay_booking));


        //            }   
        //        }
        //        cart.Clear();
        //        return RedirectToAction("Index", "Home");
        //    }

        //}



        //[HttpDelete]
        //public ActionResult DeleteItem(int id, string status_check)
        //{
        //    var cart = (Cart)Session["CartSession"];
        //    var list = cart.lines.ToList();
        //    try
        //    {
        //        foreach(var it  in list)
        //        {
        //            if(it.Product.Id == id.ToString() && it.Product.Status_checking == status_check)
        //            {
        //                cart.RemoveLineProduct(it.Product);
        //            }
        //        }
        //    }
        //    catch (Exception)
        //    {

        //    }
        //    return RedirectToAction("Booking", "User");
        //}
    }
}