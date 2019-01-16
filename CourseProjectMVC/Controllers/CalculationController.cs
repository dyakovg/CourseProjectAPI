using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CourseProjectMVC.Controllers
{
    public class CalculationController : Controller
    {
        // GET: Calculation
        public ActionResult Index()
        {
            LogicDll.SubmitBtnCalculation.Calculate(123.1m, 1m); 
            return View();
        }

        [HttpPost]
        public ActionResult Calculate()
        {
            try
            {
                decimal day = decimal.Parse(Request["value1"]);
                decimal night = decimal.Parse(Request["value2"]);
                var values = LogicDll.SubmitBtnCalculation.Calculate(day, night);
                ViewBag.values = values;
                return View();
            } catch(FormatException ex)
            {
                ViewBag.error = "Invalid parameters";
                return View();
            }

            
        }
    }
}