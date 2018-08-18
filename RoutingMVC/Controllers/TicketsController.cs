using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RoutingMVC.Models;

namespace Routing_And_MVC.Controllers
{
    public class TicketsController : Controller
    {
        //Gredy Route
        [HttpGet("/tix")]
        public IActionResult Index()
        {

            var s = new Seats() { Location = "Number 10 Orchestra", Price = "300.00" };
            return View(s);
                
                //Content( "Using IActionResult and return View");
        }

        [HttpGet("/tix2")]
        public string Index2()
        {
            return "Using String and return";
        }

    }
}