using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CNW_N8_MVC.Class
{
    public class Role
    {
        int role_id;
        string role_name;

        public int Role_id { get => role_id; set => role_id = value; }
        public string Role_name { get => role_name; set => role_name = value; }
    }
}