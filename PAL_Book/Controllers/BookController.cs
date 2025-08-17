using DAL_Book.Model;
using DAL_Book.Repo;
using Microsoft.AspNetCore.Mvc;

namespace PAL_Book.Controllers
{
   
    
        public class BookController : Controller
        {
            private readonly IRepository _repository;

            public BookController(IRepository repository)
            {
                _repository = repository;
            }

            // GET: /Book
            public IActionResult Index()
            {
                var books = _repository.GetAllBooks().ToList();
                return View(books);
            }

            // GET: /Book/Details/5
            public IActionResult Details(int id)
            {
                var book = _repository.GetBookById(id);
                if (book == null)
                    return NotFound();

                return View(book);
            }

            // GET: /Book/Create
            public IActionResult Create()
            {
                return View();
            }

            // POST: /Book/Create
            [HttpPost]
            [ValidateAntiForgeryToken]
            public IActionResult Create(BookDetail book)
            {
                if (ModelState.IsValid)
                {
                    _repository.AddBook(book);
                    return RedirectToAction(nameof(Index));
                }
                return View(book);
            }

            // GET: /Book/Edit/5
            public IActionResult Edit(int id)
            {
                var book = _repository.GetBookById(id);
                if (book == null)
                    return NotFound();

                return View(book);
            }

            // POST: /Book/Edit/5
            [HttpPost]
            [ValidateAntiForgeryToken]
            public IActionResult Edit(int id, BookDetail book)
            {
                if (id != book.ID)
                    return NotFound();

                if (ModelState.IsValid)
                {
                    _repository.UpdateBook(book);
                    return RedirectToAction(nameof(Index));
                }

                return View(book);
            }

            // GET: /Book/Delete/5
            public IActionResult Delete(int id)
            {
                var book = _repository.GetBookById(id);
                if (book == null)
                    return NotFound();

                return View(book);
            }

            // POST: /Book/Delete/5
            [HttpPost, ActionName("Delete")]
            [ValidateAntiForgeryToken]
            public IActionResult DeleteConfirmed(int id)
            {
                _repository.DeleteBook(id);
                return RedirectToAction(nameof(Index));
            }
        }
    }

