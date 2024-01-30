using Microsoft.AspNetCore.Mvc;

namespace asp_dotnet_core_calculator.Controllers.Calculator
{
    // Controller for the calculator
    [Route("calculator")]
    public class CalculatorController : Controller
    {
        // Add two numbers given in the query string
        [HttpGet("add")]
        public IActionResult Add(double numberOne, double numberTwo)
        {
            // Give the result to the view
            ViewBag.Result = numberOne + numberTwo;
            
            // Return the view
            return View();
        }

        // Subtract two numbers given in the query string
        [HttpGet("subtract")]
        public IActionResult Subtract(double numberOne, double numberTwo)
        {
            // Give the result to the view
            ViewBag.Result = numberOne - numberTwo;

            // Return the view
            return View();
        }

        // Multiply two numbers given in the query string
        [HttpGet("multiply")]
        public IActionResult Multiply(double numberOne, double numberTwo)
        {
            // Give the result to the view
            ViewBag.Result = numberOne * numberTwo;

            // Return the view
            return View();
        }

        // Divide two numbers given in the query string
        [HttpGet("divide")]
        public IActionResult Divide(double numberOne, double numberTwo)
        {
            // Give the result to the view
            ViewBag.Result = numberOne / numberTwo;

            // Return the view
            return View();
        }

        // Power two numbers given in the query string
        [HttpGet("power")]
        public IActionResult Power(double numberOne, double numberTwo)
        {
            // Give the result to the view
            ViewBag.Result = System.Math.Pow(numberOne, numberTwo);

            // Return the view
            return View();
        }

        // Root two numbers given in the query string
        [HttpGet("root")]
        public IActionResult Root(double numberOne, double numberTwo)
        {
            // Give the result to the view
            ViewBag.Result = System.Math.Pow(numberOne, 1 / numberTwo);

            // Return the view
            return View();
        }
    }
}
