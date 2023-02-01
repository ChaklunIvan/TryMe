namespace TryMe.Domain.Entities
{
    public class Question
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int TestId { get; set; }
        public Test Test { get; set; }
        public IEnumerable<Answer> Answers { get; set; }
    }
}
