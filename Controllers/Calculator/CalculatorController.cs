using Microsoft.AspNetCore.Mvc;

namespace asp_dotnet_core_calculator.Controllers.Calculator
{
    [Route("calculator")]
    public class CalculatorController : Controller
    {
        // Add two numbers given in query input
        [HttpGet("add")]
        public IActionResult Add([FromQuery] int a, [FromQuery] int b)
        {
            return Ok(a + b);
        }

        // Subtract two numbers given in query input
        [HttpGet("subtract")]
        public IActionResult Subtract(int a, int b)
        {
            return Ok(a - b);
        }

        // Multiply two numbers given in query input
        [HttpGet("multiply")]
        public IActionResult Multiply(int a, int b)
        {
            return Ok(a * b);
        }

        // Divide two numbers given in query input
        [HttpGet("divide")]
        public IActionResult Divide(int a, int b)
        {
            return Ok(a / b);
        }

        // Power two numbers given in query input
        [HttpGet("power")]
        public IActionResult Power(int a, int b)
        {
            return Ok(System.Math.Pow(a, b));
        }

        // Square root of a number given in query input
        [HttpGet("root")]
        public IActionResult Root(int a, int b)
        {
            return Ok(System.Math.Pow(a, 1 / b);
        }

        // This Code Is Not Done Yet
    }
}
