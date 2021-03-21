using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CNW_N8_MVC.Class
{
    public class BE_CommentStatistical
    {
        int comment_id;
        int hotel_id;
        int user_id;
        string content;
        string time_comment;
        string hotel_name;
        string username;

        public int Comment_id { get => comment_id; set => comment_id = value; }
        public int Hotel_id { get => hotel_id; set => hotel_id = value; }
        public int User_id { get => user_id; set => user_id = value; }
        public string Content { get => content; set => content = value; }
        public string Time_comment { get => time_comment; set => time_comment = value; }
        public string Hotel_name { get => hotel_name; set => hotel_name = value; }
        public string Username { get => username; set => username = value; }
    }
}