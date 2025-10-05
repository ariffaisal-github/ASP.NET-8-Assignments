using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BookShelf.Models;
using BookShelf.Services;

namespace BookShelf.Controllers
{
    public class BooksController : Controller
    {
        private readonly IBookService _service;
        private readonly ILogger<BooksController> _logger;

        public BooksController(IBookService service, ILogger<BooksController> logger)
        {
            _service = service;
            _logger = logger;
        }

        // GET: /Books
        public IActionResult Index()
        {
            try
            {
                var books = _service.GetAll();
                ViewData["Title"] = "Books";
                return View(books);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error loading index");
                TempData["ErrorMessage"] = "We couldn't load your books.";
                return View(new List<Book>());
            }
        }

        // GET: /Books/Details/5
        public IActionResult Details(int? id)
        {
            try
            {
                if (id is null)
                {
                    TempData["ErrorMessage"] = "No book id was provided.";
                    return RedirectToAction(nameof(Index));
                }

                var book = _service.GetById(id.Value);
                if (book == null)
                {
                    TempData["ErrorMessage"] = $"Book with id {id} was not found.";
                    return RedirectToAction(nameof(Index));
                }

                return View(book);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error loading details for id {Id}", id);
                TempData["ErrorMessage"] = "An error occurred while loading the book details.";
                return RedirectToAction(nameof(Index));
            }
        }

        // GET: /Books/Create
        public IActionResult Create()
        {
            try { return View(); }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error entering Create view");
                TempData["ErrorMessage"] = "We couldn't open the create form.";
                return RedirectToAction(nameof(Index));
            }
        }

        // POST: /Books/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Title,Author,Price")] Book book)
        {
            try
            {
                if (!ModelState.IsValid) return View(book);

                _service.Create(book);
                TempData["SuccessMessage"] = "Book created successfully.";
                return RedirectToAction(nameof(Index));
            }
            catch (ArgumentNullException ex)
            {
                _logger.LogError(ex, "Invalid data on create");
                TempData["ErrorMessage"] = "Invalid data submitted.";
                return View(book);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Unexpected error on create");
                TempData["ErrorMessage"] = "An unexpected error occurred while creating the book.";
                return View(book);
            }
        }

        // GET: /Books/Edit/5
        public IActionResult Edit(int? id)
        {
            try
            {
                if (id is null)
                {
                    TempData["ErrorMessage"] = "No book id was provided.";
                    return RedirectToAction(nameof(Index));
                }

                var book = _service.GetById(id.Value);
                if (book == null)
                {
                    TempData["ErrorMessage"] = $"Book with id {id} was not found.";
                    return RedirectToAction(nameof(Index));
                }
                return View(book);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error loading edit view for id {Id}", id);
                TempData["ErrorMessage"] = "An error occurred while preparing the edit form.";
                return RedirectToAction(nameof(Index));
            }
        }

        // POST: /Books/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("Id,Title,Author,Price")] Book book)
        {
            try
            {
                if (id != book.Id)
                {
                    TempData["ErrorMessage"] = "The route id and form id did not match.";
                    return RedirectToAction(nameof(Index));
                }

                if (!ModelState.IsValid) return View(book);

                _service.Update(book);
                TempData["SuccessMessage"] = "Book updated successfully.";
                return RedirectToAction(nameof(Index));
            }
            catch (KeyNotFoundException ex)
            {
                _logger.LogWarning(ex, "Tried to edit non-existent book id {Id}", id);
                TempData["ErrorMessage"] = "The book no longer exists.";
                return RedirectToAction(nameof(Index));
            }
            catch (ArgumentNullException ex)
            {
                _logger.LogError(ex, "Invalid data on edit for id {Id}", id);
                TempData["ErrorMessage"] = "Invalid data submitted.";
                return View(book);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Unexpected error on edit id {Id}", id);
                TempData["ErrorMessage"] = "An unexpected error occurred while updating the book.";
                return View(book);
            }
        }

        // GET: /Books/Delete/5
        public IActionResult Delete(int? id)
        {
            try
            {
                if (id is null)
                {
                    TempData["ErrorMessage"] = "No book id was provided.";
                    return RedirectToAction(nameof(Index));
                }

                var book = _service.GetById(id.Value);
                if (book == null)
                {
                    TempData["ErrorMessage"] = $"Book with id {id} was not found.";
                    return RedirectToAction(nameof(Index));
                }

                return View(book);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error loading delete view for id {Id}", id);
                TempData["ErrorMessage"] = "An error occurred while preparing the delete confirmation.";
                return RedirectToAction(nameof(Index));
            }
        }

        // POST: /Books/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            try
            {
                _service.Delete(id);
                TempData["SuccessMessage"] = "Book deleted successfully.";
                return RedirectToAction(nameof(Index));
            }
            catch (KeyNotFoundException ex)
            {
                _logger.LogWarning(ex, "Tried to delete non-existent book id {Id}", id);
                TempData["ErrorMessage"] = "The book was already deleted or never existed.";
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Unexpected error on delete id {Id}", id);
                TempData["ErrorMessage"] = "An unexpected error occurred while deleting the book.";
                return RedirectToAction(nameof(Index));
            }
        }
    }
}
