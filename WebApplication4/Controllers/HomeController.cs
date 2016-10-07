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
                //创建mysqlcommand对象，进行插入更新或者删除数据
                MySqlCommand com = new MySqlCommand();
                com.Connection = conn;
                com.CommandText = "insert into newtable1 values(0,'wang'),(0,'fang');";
                com.CommandText += "update newtable1 set name='ping' where id=2";
                //i 表示影响行数
                int i = com.ExecuteNonQuery();          
                ViewBag.a =i;

                //ViewBag.a = "成功";
                return View();
            }
            ViewBag.a = "失败";
                return View();

        }
    }
}