namespace Domain
{
    public class Profile : Entity
    {
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Password { get; set; }

        public ICollection<Note> Notes { get; set; }
    }
}
