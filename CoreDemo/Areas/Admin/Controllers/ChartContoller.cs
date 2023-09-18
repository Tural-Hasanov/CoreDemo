using CoreDemo.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Areas.Admin.Controllers
{
    [Area("Admin")]
    
    public class ChartContoller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CategoryChart()
        {
            List<CategoryClass> list = new List<CategoryClass>();
            list.Add(new CategoryClass
            {
                categoryname = "Texnologiya",
                categorycount = 10
            });
            list.Add(new CategoryClass
            {
                categoryname = "Proqramlama",
                categorycount = 14
            });
            list.Add(new CategoryClass
            {
                categoryname = "İdman",
                categorycount = 5
            });
            return Json(new { jsonList = list });
        }
    }
}
