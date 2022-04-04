using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission13.Models;

namespace Mission13.Controllers
{
    public class HomeController : Controller
    {
        private IBowlersRepository _repo { get; set; }

        public HomeController(IBowlersRepository temp)
        {
            _repo = temp;
        }

        public IActionResult Index()
        {
            var blah = _repo.Bowlers
                .ToList();

            return View(blah);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View("Form");
        }

        [HttpPost]
        public IActionResult Add(Bowler bowler)
        {
            _repo.AddBowler(bowler);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var form = _repo.Bowlers.Single(x => x.BowlerID == id);
            return View("Form", form);
        }

        [HttpPost]
        public IActionResult Edit(Bowler bowler)
        {
            _repo.UpdateBowler(bowler);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var delete = _repo.Bowlers.Single(x => x.BowlerID == id);
            _repo.DeleteBowler(delete);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete()
        {
            return RedirectToAction("Index");
        }

    }
}
