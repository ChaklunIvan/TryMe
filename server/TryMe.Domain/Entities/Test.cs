namespace TryMe.Domain.Entities
{
    public class Test
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public User User { get; set; }
        public IEnumerable<Question> Questions { get; set; }
    }
}
