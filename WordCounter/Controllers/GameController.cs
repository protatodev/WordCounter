using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;

namespace WordCounter.Controllers
{
    public class GameController : Controller
    {
        [HttpGet("/form")]
        public ActionResult Form()
        {
            return View();
        }
    }
}
