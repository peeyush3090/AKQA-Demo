using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services;
using WebAppNumberToWords.Service;

namespace WebAppNumberToWords.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public string NumbertoWord(string name, string number)
        {
            NumberToWordServices obj = new NumberToWordServices();
            return obj.GetName(name) + " " + obj.GetConvertedNumber(number);
        }
    }
}