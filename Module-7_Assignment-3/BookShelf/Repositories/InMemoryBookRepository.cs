using System;
using System.Collections.Generic;
using System.Linq;
using BookShelf.Models;

namespace BookShelf.Repositories
{
    public class InMemoryBookRepository : IBookRepository
    {
        private static readonly List<Book> _books = new();
        private static int _nextId = 1;

        public InMemoryBookRepository()
        {
            if (_books.Count == 0)
            {
                _books.AddRange(new[] {
                    new Book { Id = _nextId++, Title = "Clean Code", Author = "Robert C. Martin", Price = 49.99m },
                    new Book { Id = _nextId++, Title = "The Pragmatic Programmer", Author = "Andrew Hunt & David Thomas", Price = 39.99m }
                });
            }
        }

        public IEnumerable<Book> GetAll() => _books;
        public Book? GetById(int id) => _books.FirstOrDefault(b => b.Id == id);

        public void Add(Book book)
        {
            if (book == null) throw new ArgumentNullException(nameof(book));
            book.Id = _nextId++;
            _books.Add(book);
        }

        public void Update(Book book)
        {
            if (book == null) throw new ArgumentNullException(nameof(book));
            var existing = _books.FirstOrDefault(b => b.Id == book.Id)
                           ?? throw new KeyNotFoundException($"Book with id {book.Id} not found.");
            existing.Title = book.Title;
            existing.Author = book.Author;
            existing.Price = book.Price;
        }

        public void Delete(int id)
        {
            var existing = _books.FirstOrDefault(b => b.Id == id)
                           ?? throw new KeyNotFoundException($"Book with id {id} not found.");
            _books.Remove(existing);
        }
    }
}
