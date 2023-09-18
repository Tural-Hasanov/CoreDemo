﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class MessageController : Controller
    {

        Message2Manager mm = new Message2Manager(new EfMessage2Repository());
        [AllowAnonymous]
        public IActionResult Inbox()
        {
            int id = 2;
            var values = mm.GetInboxListByWriter(id);
            return View(values);
        }
        [AllowAnonymous]
        public IActionResult MessageDetails(int id)
        {
            var value = mm.TGetbyID(id);
            return View(value);
        }
    }
}
