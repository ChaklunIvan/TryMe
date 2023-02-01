using TryMe.Domain.Entities;
using TryMe.Domain.Responses;

namespace TryMe.Services.Interfaces
{
    public interface ITestService
    {
        Task<IEnumerable<TestResponse>> GetTestListAsync(int UserId, CancellationToken cancellationToken);
    }
}
