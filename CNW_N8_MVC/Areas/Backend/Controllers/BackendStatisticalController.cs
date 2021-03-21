using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using CNW_N8_MVC.Class;
using System.IO;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CNW_N8_MVC.Areas.Backend.Controllers
{
    public class BackendStatisticalController : Controller
    {
        // GET: Backend/BackendStatistical
        static Server.ServerSoapClient server = new Server.ServerSoapClient();
        static List<BE_CommentStatistical> cmts = JsonConvert.DeserializeObject<List<BE_CommentStatistical>>(server.BE_GetCommentStatistical());
        static List<BE_CommentStatistical> list = new List<BE_CommentStatistical>();
        static List<BE_OrderStatistical> orders = JsonConvert.DeserializeObject<List<BE_OrderStatistical>>(server.BE_GetOrderStatistical());
        static List<BE_OrderStatistical> list_order = new List<BE_OrderStatistical>();
        static string f_date_s;
        static string t_date_s;
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult OrderStatistical()
        {
            foreach (var it in orders)
            {
                it.Time_booking = Convert.ToDateTime(it.Time_booking).ToString();
            }
            ViewData["orders"] = orders;
            ViewData["list_order"] = list_order;
            ViewData["f_date"] = f_date_s;
            ViewData["t_date"] = t_date_s;
            return View();
        }
        [HttpGet]
        public ActionResult SearchOrder()
        {
            string t_date = Request["to_date"];
            string f_date = Request["from_date"];
            f_date_s = f_date;
            t_date_s = t_date;
            list_order.Clear();
            if (t_date == "" && f_date == "")
            {
                list_order = orders;
                return RedirectToAction("OrderStatistical", "BackendStatistical", new { area = "Backend" });
            }
            else if (f_date == "")
            {
                var to_date = Convert.ToDateTime(Request["to_date"]);
                foreach (var it in orders.ToList())
                {
                    DateTime time = Convert.ToDateTime(it.Time_booking);
                    if ((time <= to_date))
                    {
                        list_order.Add(it);
                    }
                }
                return RedirectToAction("OrderStatistical", "BackendStatistical", new { area = "Backend" });
            }
            else if (t_date == "")
            {
                var from_date = Convert.ToDateTime(Request["from_date"]);
                foreach (var it in orders.ToList())
                {
                    DateTime time = Convert.ToDateTime(it.Time_booking);
                    if ((time >= from_date))
                    {
                        list_order.Add(it);
                    }
                }
                return RedirectToAction("OrderStatistical", "BackendStatistical", new { area = "Backend" });

            }
            else
            {
                var from_date = Convert.ToDateTime(Request["from_date"]);
                var to_date = Convert.ToDateTime(Request["to_date"]);
                foreach (var it in orders.ToList())
                {
                    DateTime time = Convert.ToDateTime(it.Time_booking);
                    if ((time >= from_date && time <= to_date))
                    {
                        list_order.Add(it);
                    }
                }
                return RedirectToAction("OrderStatistical", "BackendStatistical", new { area = "Backend" });
            }

        }

        public ActionResult CommentStatistical()
        {
            foreach (var it in cmts)
            {
                it.Time_comment = Convert.ToDateTime(it.Time_comment).ToString();
            }
            ViewData["listCmt"] = cmts;
            ViewData["listSearch"] = list;
            ViewData["f_date"] = f_date_s;
            ViewData["t_date"] = t_date_s;

            return View();
        }
        [HttpGet]
        public ActionResult SearchComment()
        {
            string t_date = Request["to_date"];
            string f_date = Request["from_date"];
            f_date_s = f_date;
            t_date_s = t_date;
            list.Clear();
            if (t_date == "" && f_date == "")
            {
                list = cmts;
                return RedirectToAction("CommentStatistical", "BackendStatistical", new { area = "Backend" });
            }
            else if (f_date == "")
            {
                var to_date = Convert.ToDateTime(Request["to_date"]);
                foreach (var it in cmts.ToList())
                {
                    DateTime time = Convert.ToDateTime(it.Time_comment);
                    if ((time <= to_date))
                    {
                        list.Add(it);
                    }
                }
                return RedirectToAction("CommentStatistical", "BackendStatistical", new { area = "Backend" });
            }
            else if (t_date == "")
            {
                var from_date = Convert.ToDateTime(Request["from_date"]);
                foreach (var it in cmts.ToList())
                {
                    DateTime time = Convert.ToDateTime(it.Time_comment);
                    if ((time >= from_date))
                    {
                        list.Add(it);
                    }
                }
                return RedirectToAction("CommentStatistical", "BackendStatistical", new { area = "Backend" });

            }
            else
            {
                var from_date = Convert.ToDateTime(Request["from_date"]);
                var to_date = Convert.ToDateTime(Request["to_date"]);
                foreach (var it in cmts.ToList())
                {
                    DateTime time = Convert.ToDateTime(it.Time_comment);
                    if ((time >= from_date && time <= to_date))
                    {
                        list.Add(it);
                    }
                }
                return RedirectToAction("CommentStatistical", "BackendStatistical", new { area = "Backend" });
            }
            
        }
        [HttpGet]
        public void ExportOrder()
        {
            var gv = new GridView();
            if (list_order.Count() != 0)
            {
                gv.DataSource = list_order;
            }
            else
            {
                gv.DataSource = orders;
            }

            gv.DataBind();
            Response.Clear();
            Response.Buffer = true;
            //Response.AddHeader("content-disposition",
            // "attachment;filename=GridViewExport.xls");
            Response.Charset = "utf-8";
            Response.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
            Response.AddHeader("content-disposition", "attachment;filename=GridViewExport.xls");
            //Mã hóa chữa sang UTF8
            Response.ContentEncoding = System.Text.Encoding.UTF8;
            Response.BinaryWrite(System.Text.Encoding.UTF8.GetPreamble());

            StringWriter sw = new StringWriter();
            HtmlTextWriter hw = new HtmlTextWriter(sw);

            for (int i = 0; i < gv.Rows.Count; i++)
            {
                //Apply text style to each Row
                gv.Rows[i].Attributes.Add("class", "textmode");
            }
            //Add màu nền cho header của file excel
            gv.HeaderRow.BackColor = System.Drawing.Color.DarkBlue;
            //Màu chữ cho header của file excel
            gv.HeaderStyle.ForeColor = System.Drawing.Color.White;

            gv.HeaderRow.Cells[0].Text = "Mã Hoá Đơn";
            gv.HeaderRow.Cells[1].Text = "Mã Khách Hàng";
            gv.HeaderRow.Cells[2].Text = "Thời Gian";
            gv.HeaderRow.Cells[3].Text = "Tổng Hoá Đơn";
            gv.HeaderRow.Cells[4].Text = "Trạng Thái";
            gv.HeaderRow.Cells[5].Text = "Tên Khách Hàng";
            gv.RenderControl(hw);

            Response.Output.Write(sw.ToString());
            Response.Flush();
            Response.End();
        }
        [HttpGet]
        public void Export()
        {
            var gv = new GridView();
            if(list.Count() != 0)
            {
                gv.DataSource = list;
            }
            else
            {
                gv.DataSource = cmts;
            }
            
            gv.DataBind();
            Response.Clear();
            Response.Buffer = true;
            //Response.AddHeader("content-disposition",
            // "attachment;filename=GridViewExport.xls");
            Response.Charset = "utf-8";
            Response.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
            Response.AddHeader("content-disposition", "attachment;filename=GridViewExport.xls");
            //Mã hóa chữa sang UTF8
            Response.ContentEncoding = System.Text.Encoding.UTF8;
            Response.BinaryWrite(System.Text.Encoding.UTF8.GetPreamble());

            StringWriter sw = new StringWriter();
            HtmlTextWriter hw = new HtmlTextWriter(sw);

            for (int i = 0; i < gv.Rows.Count; i++)
            {
                //Apply text style to each Row
                gv.Rows[i].Attributes.Add("class", "textmode");
            }
            //Add màu nền cho header của file excel
            gv.HeaderRow.BackColor = System.Drawing.Color.DarkBlue;
            //Màu chữ cho header của file excel
            gv.HeaderStyle.ForeColor = System.Drawing.Color.White;

            gv.HeaderRow.Cells[0].Text = "Mã Comment";
            gv.HeaderRow.Cells[1].Text = "Mã Khách Sạn";
            gv.HeaderRow.Cells[2].Text = "Mã Người Dùng";
            gv.HeaderRow.Cells[3].Text = "Nội Dung";
            gv.HeaderRow.Cells[4].Text = "Thời Gian";
            gv.HeaderRow.Cells[5].Text = "Tên Khách Sạn";
            gv.HeaderRow.Cells[6].Text = "Tên Người Dùng";
            gv.RenderControl(hw);

            Response.Output.Write(sw.ToString());
            Response.Flush();
            Response.End();
        }

    }
}