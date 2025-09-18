using LibraryManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagement.Controllers {
    public class BookController : Controller {

        private static List<BookViewModel>? _books;
        public BookController() {
            if (_books == null) {
                _books = new List<BookViewModel>();
                CreateDummyBooks();
            }
        }
        public IActionResult GetAll() {
            return View(_books);
        }

        public IActionResult Edit(int bookId) {
            BookViewModel? selectedBook = _books.FirstOrDefault(b => b.Id == bookId);
            return View(selectedBook);
        }

        [HttpPost]
        public IActionResult Update(BookViewModel updatedBook) {
            var book = _books.FirstOrDefault(b => b.Id == updatedBook.Id);
            book.Author = updatedBook.Author;
            book.Title = updatedBook.Title;
            book.Genre = updatedBook.Genre;
            return RedirectToAction("GetAll");
        }

        private void CreateDummyBooks() {
            _books.Add(new BookViewModel { Id = 1, Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", Genre = "Fiction" });
            _books.Add(new BookViewModel { Id = 2, Title = "To Kill a Mockingbird", Author = "Harper Lee", Genre = "Fiction" });
            _books.Add(new BookViewModel { Id = 3, Title = "1984", Author = "George Orwell", Genre = "Dystopian" });
            _books.Add(new BookViewModel { Id = 4, Title = "Pride and Prejudice", Author = "Jane Austen", Genre = "Romance" });
            _books.Add(new BookViewModel { Id = 5, Title = "The Catcher in the Rye", Author = "J.D. Salinger", Genre = "Fiction" });
            _books.Add(new BookViewModel { Id = 6, Title = "The Hobbit", Author = "J.R.R. Tolkien", Genre = "Fantasy" });
        }
    }
}
