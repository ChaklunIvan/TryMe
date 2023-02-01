namespace TryMe.Domain.Entities
{
    public class Test
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public int UserId { get; set; }
        public virtual User? User { get; set; }
        public virtual IEnumerable<Question>? Questions { get; set; }
    }
}
