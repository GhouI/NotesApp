namespace NotesApp.Models
{
    public class Note
    {
        public int Id { get; set; }
        
        public string NoteName { get; set; }
        public string NoteContent { get; set; }
        public string NoteType { get; set; }
        public Note() { }

    }
}
