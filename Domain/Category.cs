namespace Domain
{
    public class Category : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<Note> Notes { get; set; }

        public void AddNote(Note note)
        {
            note.CategoryId = Id;
            Notes.Add(note);
        }
    }
}
