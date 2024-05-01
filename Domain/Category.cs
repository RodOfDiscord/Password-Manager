namespace Domain
{
    public class Category : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<Note> Notes { get; set; }
    }
}
