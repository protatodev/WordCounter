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
            RepeatCounter repeat = new RepeatCounter();
            repeat.word = Request.Form["new-word"];
            repeat.phrase = Request.Form["new-phrase"];
            repeat.phrase = repeat.RemoveSpecialCharacters(repeat.phrase);
            repeat.word = repeat.RemoveSpecialCharacters(repeat.word);
            repeat.word = repeat.RemoveWhiteSpace(repeat.word);
            return View("Results", repeat);
        }

        [HttpGet("/results")]
        public ActionResult Results()
        {
            return View();
        }
    }
}
