﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication2.Models;

using Microsoft.AspNetCore.Http;

//using Npgsql;
using System.Data.SqlClient;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            HttpContext.Session.SetString("TestId", DateTime.Now.ToString());
            return View();
        }

        public IActionResult Privacy()
        {
        	string count = "";
            // Docker Compose
            using (var con = new SqlConnection("Data Source=sqlserver;Initial Catalog=Northwind;User ID=sa;Password=seigi@123;"))
            {
                con.Open();
                var cmd = new SqlCommand(@"select count(*) from shippers", con);
                count = cmd.ExecuteScalar().ToString();
            }
            ViewData["Message1"] = "Your application description page. " + count + "件";
            ViewData["Message2"] = "Your contact page. " + HttpContext.Session.GetString("TestId");

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
