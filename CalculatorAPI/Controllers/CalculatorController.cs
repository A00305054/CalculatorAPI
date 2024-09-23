using Microsoft.AspNetCore.Mvc;

namespace CalculatorAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        // Add method: Handles a GET request and returns the sum of two numbers
        [HttpGet("add")]
        public IActionResult Add([FromQuery] decimal a, [FromQuery] decimal b)
        {
            return Ok(a + b);
        }

        // Subtract method: Handles a GET request and returns the difference of two numbers
        [HttpGet("subtract")]
        public IActionResult Subtract([FromQuery] decimal a, [FromQuery] decimal b)
        {
            return Ok(a - b);
        }

        // Multiply method: Handles a GET request and returns the product of two numbers
        [HttpGet("multiply")]
        public IActionResult Multiply([FromQuery] decimal a, [FromQuery] decimal b)
        {
            return Ok(a * b);
        }

        

        // Modulo method: Handles a GET request and returns the remainder of two numbers
        [HttpGet("modulo")]
        public IActionResult Modulo([FromQuery] decimal a, [FromQuery] decimal b)
        {
            if (b == 0)
            {
                return BadRequest("Modulo by zero is not allowed.");
            }
            return Ok(a % b);
        }
    }
}
