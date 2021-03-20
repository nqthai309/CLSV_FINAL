using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Server3.Class
{
    public class ItemComment
    {
        CommentRoot cmtRoot;
        List<CommentChild> cmtChildren;

        public CommentRoot CmtRoot { get => cmtRoot; set => cmtRoot = value; }
        public List<CommentChild> CmtChildren { get => cmtChildren; set => cmtChildren = value; }
    }
}