using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CoreDemo.Areas.Admin.ViewComponents.Statistic
{
    public class Statistic1 : ViewComponent
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            var values = bm.GetList().Count();
            ViewBag.count = values;
            var values1 = c.Contacts.Count();
            ViewBag.count1 = values1;
            var values2 = c.Comments.Count();
            ViewBag.count2 = values2;
            string api = "14ad2aba611dbef9c504b82a127794c5";
            string connection = "https://api.openweathermap.org/data/2.5/weather?q=Baku&mode=xml&lang=tr&units=metric&appid=" + api;
            XDocument document = XDocument.Load(connection);
            ViewBag.v4 = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            return View();


        }
    }
}
