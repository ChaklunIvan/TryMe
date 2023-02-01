using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TryMe.Domain.Entities;
using TryMe.Services.Interfaces;

namespace TryMe.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly ITestService _testService;

        public TestController(ITestService testService)
        {
            _testService = testService;
        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult<IEnumerable<Test>>> GetTestListAsync(CancellationToken cancellationToken)
        {
            var userId = HttpContext.User.Claims.FirstOrDefault(c => c.Type == "UserId")?.Value;
            var tests = await _testService.GetTestListAsync(int.Parse(userId), cancellationToken);

            return Ok(tests);
        }
    }
}
