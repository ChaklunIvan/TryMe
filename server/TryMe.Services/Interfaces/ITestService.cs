using TryMe.Domain.Entities;
using TryMe.Domain.Responses;

namespace TryMe.Services.Interfaces
{
    public interface ITestService
    {
        Task<IEnumerable<TestResponse>> GetTestsAsync(int userId, CancellationToken cancellationToken);
        Task<IEnumerable<QuestionResponse>> GetQuestionsAsync(int testId, CancellationToken cancellationToken);
    }
}
