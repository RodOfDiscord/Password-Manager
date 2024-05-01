namespace Domain
{
    public class Note : Entity
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }

        public Guid ProfileId { get; set; }
        public Profile Profile { get; set; }

        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
