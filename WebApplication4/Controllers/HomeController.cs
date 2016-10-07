using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MySql.Data.MySqlClient;


namespace WebApplication4.Controllers
{


    public class HomeController : Controller
    {
        MySqlConnection conn = null;

     // GET: Home
        public ActionResult Index()
        {
            ViewBag.a = "初始化";
            conn = new MySqlConnection("Server=localhost;Database=test;Username=root;Password=123209");
            conn.Open();
            if (conn.State.ToString()=="Open")
            {
                ViewBag.a = "成功";
                return View();
            }
            ViewBag.a = "失败";
                return View();

        }
    }
}