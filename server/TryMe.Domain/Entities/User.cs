namespace TryMe.Domain.Entities
{
    public class User
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public IEnumerable<Test> Tests { get; set; }
    }
}
