namespace LibraryManagement.Models {
    public class BookViewModel {
        public int Id { get; set; }
        public required string Title { get; set; }
        public required string Author { get; set; }
        public string? Genre { get; set; }
    }
}
