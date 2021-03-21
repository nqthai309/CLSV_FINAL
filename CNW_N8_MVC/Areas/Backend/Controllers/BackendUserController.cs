using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Dynamic;
using Newtonsoft;
using CNW_N8_MVC.Entites;
using Newtonsoft.Json;
using CNW_N8_MVC.Class;


namespace CNW_N8_MVC.Areas.Backend.Controllers
{
    public class BackendUserController : BaseController
    {

        static Server.ServerSoapClient server = new Server.ServerSoapClient();


        static int id_old;
        // GET: User
        public ActionResult List()
        {
            List<Users_BE> listUser = new List<Users_BE>();
            listUser = JsonConvert.DeserializeObject<List<Users_BE>>(server.BE_GetListUser());
            return View(listUser);
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddUser(Users_BE_Add acc)
        {
            string json = JsonConvert.SerializeObject(acc);
            server.BE_AddUser(json);
            return RedirectToAction("List", "BackendUser", new { area = "Backend" });
        }

        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return RedirectToAction("List", "BackendUser", new { area = "Backend" });
            }
            else
            {
                int a;
                bool check = int.TryParse(id.ToString(), out a);
                if (check == true)
                {
                    var model = JsonConvert.DeserializeObject<List<Users_BE_Add>>(server.BE_FindUserByUser_id(a.ToString()));
                    if (model == null)
                    {
                        return RedirectToAction("List", "BackendUser", new { area = "Backend" });
                    }
                    else
                    {
                        id_old = a;
                        ViewData["acc"] = model;
                        return View();
                    }
                }
                else
                {
                    return RedirectToAction("List", "BackendUser", new { area = "Backend" });
                }
            }

        }



        [HttpPost]
        public ActionResult EditUser(users acc)
        {
            //var result = context.users.Find(id_old);
            //context.users.Remove(result);
            //context.users.Add(acc);
            //context.SaveChanges();
            string json = JsonConvert.SerializeObject(acc);
            server.EditUser_BE(json);
            return RedirectToAction("List", "BackendUser", new { area = "Backend" });



        }


        public ActionResult DeleteUser(string id)
        {
            if (id == null)
            {
                return RedirectToAction("List", "BackendUser", new { area = "Backend" });
            }
            else
            {
                int a;
                bool check = int.TryParse(id.ToString(), out a);
                if (check == true)
                {
                    var result = server.FE_FindUserByUser_id(a.ToString());
                    if (result == null)
                    {
                        return RedirectToAction("List", "BackendUser", new { area = "Backend" });
                    }
                    else
                    {
                        //context.users.remove(result);
                        //context.savechanges();

                        server.BE_DeleteUser(int.Parse(id));

                        return RedirectToAction("List", "BackendUser", new { area = "Backend" });
                    }

                }
                else
                {
                    return RedirectToAction("List", "BackendUser", new { area = "Backend" });
                }
            }

        }

        //public int checkEditUser(string username, string password, string phone, string email, string address, string role_id, string full_name)
        //{
        //    if (username == "" || password == "" || email == "" || address == "" || role_id == "" || full_name == "" || phone == "")
        //    {
        //        return -1;
        //    }
        //    else
        //    {
        //        return 1;
        //        //var result = context.users.Where(u => (u.username == username)).FirstOrDefault();
        //        //var userOld = context.users.Find(id_old);

        //        //if (result == null || (result.username == userOld.username))
        //        //{
        //        //    return 1;
        //        //}
        //        //else
        //        //{
        //        //    return -1;
        //        //}
        //    }
        //}



        public ActionResult LogoutBackend()
        {
            Session["LoginBackend"] = null;

            return RedirectToAction("Index", "Home", new { area = "Backend" });

        }

    }
}