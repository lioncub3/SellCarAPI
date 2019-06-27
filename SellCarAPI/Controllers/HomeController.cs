using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SellCarAPI.Controllers
{
    public class HomeController : Controller
    {
        [Route("Cars/{brand:alpha}/{year:int:min(1970)}/{color:alpha?}")]
        public IActionResult Index(string brand, int year, string color = "black")
        {
            return Content($"Brand: {brand}, \nyear: {year}, \ncolor: {color}");
        }
    }
}