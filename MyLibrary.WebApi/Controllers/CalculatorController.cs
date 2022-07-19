using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyLibrary.WebApi.Controllers
{
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        private readonly Calculator _calculator;

        public CalculatorController(Calculator calculator)
        {
            _calculator = calculator;
        }

        [HttpGet]
        [Route("/calculator/add/{a}/{b}")]
        public IActionResult Add([FromRoute]int a, [FromRoute] int b)
        {
            var result = _calculator.Add(a, b);

            return Ok(result);
        }

        [HttpGet]
        [Route("/calculator/sub/{a}/{b}")]
        public IActionResult Sub([FromRoute] int a, [FromRoute] int b)
        {
            var result = _calculator.Sub(a, b);

            return Ok(result);
        }
    }
}
