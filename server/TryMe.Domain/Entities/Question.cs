namespace TryMe.Domain.Entities
{
    public class Question
    {
        public int Id { get; set; }
        public string Answer { get; set; }
        public bool IsCorrect { get; set; }
        public Test Test { get; set; }
    }
}
