﻿namespace TryMe.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string? PasswordHash { get; set; }
        public virtual IEnumerable<Test>? Tests { get; set; }
    }
}
