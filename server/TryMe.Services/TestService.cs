using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TryMe.Data;
using TryMe.Domain.Entities;
using TryMe.Domain.Responses;
using TryMe.Services.Interfaces;

namespace TryMe.Services
{
    public class TestService : ITestService
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public TestService(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<TestResponse>> GetTestsAsync(int userId, CancellationToken cancellationToken)
        {
            var tests = await _context.Tests.Where(t => t.UserId == userId).ToListAsync(cancellationToken);
            var testsResponse = _mapper.Map<IEnumerable<TestResponse>>(tests);

            return testsResponse;
        }

        public async Task<IEnumerable<QuestionResponse>> GetQuestionsAsync(int testId, CancellationToken cancellationToken)
        {
            var questions = await _context.Questions.Where(q => q.TestId == testId).ToListAsync(cancellationToken);
            var questionsResponse = _mapper.Map<IEnumerable<QuestionResponse>>(questions);

            return questionsResponse;
        }
    }
}
