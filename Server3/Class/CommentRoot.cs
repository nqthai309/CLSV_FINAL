using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Server3.Class
{
    public class CommentRoot
    {
        int comment_id;
        int hotel_id;
        string username;
        string content;
        string time_comment;

        public int Comment_id { get => comment_id; set => comment_id = value; }
        public int Hotel_id { get => hotel_id; set => hotel_id = value; }
        public string Username { get => username; set => username = value; }
        public string Content { get => content; set => content = value; }
        public string Time_comment { get => time_comment; set => time_comment = value; }
    }
}