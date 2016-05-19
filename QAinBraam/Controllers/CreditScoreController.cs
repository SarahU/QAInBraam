using QAinBraam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QAinBraam.Controllers
{
    public class CreditScoreController : Controller
    {
        public ActionResult Index()
        {
            var model = new CreditScore()
            {
                Name = "Sarah",
                Score = 1000000
            };
            return View(model);
        }

        public ActionResult Calculate(CreditScore creditScore)
        {
            creditScore.Score -= 100000;
            return View("Index", creditScore);
        }
    }
}