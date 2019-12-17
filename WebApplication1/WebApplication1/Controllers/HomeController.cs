using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

using Microsoft.AspNetCore.Http;

//using Npgsql;
using System.Data.SqlClient;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            HttpContext.Session.SetString("TestId", DateTime.Now.ToString());
            return View();
        }

        public IActionResult About()
        {
            string count = "";
            using (var con = new SqlConnection("Data Source=10.0.75.1\\sqlexpress;Initial Catalog=Northwind;User ID=sa;Password=seigi@123;"))
            {
                con.Open();
                var cmd = new SqlCommand(@"select count(*) from shippers", con);
                count = cmd.ExecuteScalar().ToString();
            }
            ViewData["Message"] = "Your application description page. " + count + "件";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page. " + HttpContext.Session.GetString("TestId");

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
