using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EJ2_Core_Application.Models;
using Newtonsoft.Json;

namespace EJ2_Core_Application.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<MarkerData> data = new List<MarkerData>
            {
                 new MarkerData {latitude= 37.0000, longitude= -120.0000, city= "California" },
                 new MarkerData {latitude= 40.7127, longitude= -74.0059, city= "New York" },
                 new MarkerData {latitude= 42.0000, longitude= -93.0000, city= "Iowa" }
            };
            ViewBag.markerData = data;
            return View();
        }
        public class MarkerData
        {
            public double latitude { get; set; }
            public double longitude { get; set; }
            public string city { get; set; }
        }
    }
}
