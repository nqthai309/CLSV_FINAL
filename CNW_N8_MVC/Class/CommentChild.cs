using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CNW_N8_MVC.Class
{
    public class CommentChild
    {
        int comments_child;
        int comment_id;
        string username;
        string content;

        public int Comments_child { get => comments_child; set => comments_child = value; }
        public int Comment_id { get => comment_id; set => comment_id = value; }
        public string Username { get => username; set => username = value; }
        public string Content { get => content; set => content = value; }
    }
}