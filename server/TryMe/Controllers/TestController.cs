using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TryMe.Domain.Entities;
using TryMe.Domain.Responses;
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
        public async Task<ActionResult<IEnumerable<TestResponse>>> GetTestListAsync(CancellationToken cancellationToken)
        {
            var userId = HttpContext.User.Claims.FirstOrDefault(c => c.Type == "UserId")?.Value;
            var tests = await _testService.GetTestsAsync(int.Parse(userId), cancellationToken);

            return Ok(tests);
        }

        [HttpGet("{testId}/Questions")]
        [Authorize]
        public async Task<ActionResult<IEnumerable<QuestionResponse>>> GetQuestionListAsync(int testId, CancellationToken cancellationToken)
        {
            var questions = await _testService.GetQuestionsAsync(testId, cancellationToken);

            return Ok(questions);
        }
    }
}
