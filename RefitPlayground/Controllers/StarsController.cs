using Microsoft.AspNetCore.Mvc;

namespace RefitPlayground.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StarsController : ControllerBase
    {

        [HttpGet("/{count}")]
        public async Task<string> GetAsync(int count)
        {
            await Task.Delay(500);
            return new string('*', count);
        }

        [HttpGet("/double/{count}")]
        public async Task<string> GetDoubleAsync(int count)
        {
            await Task.Delay(500);
            return new string('*', count * 2);
        }
    }
}