namespace TryMe.Domain.Responses
{
    public class QuestionResponse
    {
        public string? Description { get; set; }
        public IEnumerable<AnswerResponse>? Answers { get; set; }
    }
}
