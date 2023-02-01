namespace TryMe.Domain.Entities
{
    public class Answer
    {
        public int Id { get; set; }
        public string? Body { get; set; }
        public bool IsCorrect { get; set; }
        public virtual Question? Question { get; set; }
        public virtual int QuestionId { get; set; }
    }
}
