using CalculatorDotNet.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc.ViewEngines;

namespace CalculatorDotNet.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(CalculatorModel cal)
        {
            float result = cal.value1 + cal.value2;

            ViewBag.result = result;

            return View("/Views/Display/Display.cshtml");
        }

        [HttpPost]
        public IActionResult Substract(CalculatorModel cal)
        {
            float result = cal.value1 - cal.value2;

            ViewBag.result = result;

            return View("/Views/Display/Display.cshtml");
        }

        [HttpPost]
        public IActionResult Multiply(CalculatorModel cal)
        {
            float result = cal.value1 * cal.value2;

            ViewBag.result = result;

            return View("/Views/Display/Display.cshtml");
        }

        [HttpPost]
        public IActionResult Divide(CalculatorModel cal)
        {
            float result = cal.value1 / cal.value2;

            ViewBag.result = result;

            return View("/Views/Display/Display.cshtml");
        }
    }
}
