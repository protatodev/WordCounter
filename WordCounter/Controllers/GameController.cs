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

        [HttpPost("/results")]
        public ActionResult ResultsPost()
        {
            RepeatCounter repeat = new RepeatCounter(Request.Form["new-word"], Request.Form["new-phrase"]);
            repeat.counts = repeat.CountOccurences(repeat.SplitPhrase());
            return View("Results", RepeatCounter.searches);
        }

        [HttpGet("/results")]
        public ActionResult Results()
        {
            return View();
        }

        [HttpGet("/results/{id}")]
        public ActionResult Item(int id)
        {
            RepeatCounter repeat = RepeatCounter.searches[id];
            return View(repeat);
        }
    }
}
