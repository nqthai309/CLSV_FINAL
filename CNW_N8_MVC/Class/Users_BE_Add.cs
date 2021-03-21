using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CNW_N8_MVC.Class
{
    public class Users_BE_Add
    {
        int user_id;
        string username;
        string password;
        int role_id;
        string full_name;
        string email;
        string phone;
        string address;
        double point;
        int discount_id;

        public int User_id { get => user_id; set => user_id = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public int Role_id { get => role_id; set => role_id = value; }
        public string Full_name { get => full_name; set => full_name = value; }
        public string Email { get => email; set => email = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Address { get => address; set => address = value; }
        public double Point { get => point; set => point = value; }
        public int Discount_id { get => discount_id; set => discount_id = value; }
    }
}