using Microsoft.AspNetCore.Mvc;
using ObjectiveTestExercise2.Services;

namespace ObjectiveTestExercise2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CountController : ControllerBase
    {

        [HttpGet("GetCount")]
        public int GetCount()
        {
            return CounterService.GetCount();
        }

        [Route("AddCount/{number}")]
        [HttpGet("{number}")]
        public IActionResult AddCount(int number)
        {
            try
            {
                CounterService.AddCount(number);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
