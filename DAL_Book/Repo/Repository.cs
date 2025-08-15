using DAL_Book.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Book.Repo
{
    public class Repository : IRepository
    {
        private readonly BookDbContext _context;

        public Repository(BookDbContext context)
        {
            _context = context;
        }

        public void AddBook(BookDetail book)
        {
            _context.BookDetails.Add(book);
            _context.SaveChanges();
        }

        public void DeleteBook(int bookId)
        {
            var book = _context.BookDetails.Find(bookId);
            if (book != null)
            {
                _context.BookDetails.Remove(book);
                _context.SaveChanges();
            }
        }

        public BookDetail GetBookById(int bookId)
        {
            return _context.BookDetails.Find(bookId);
        }

        public IEnumerable<BookDetail> GetAllBooks()
        {
            return _context.BookDetails.ToList();
        }

        public void UpdateBook(BookDetail book)
        {
            var existing = _context.BookDetails.Find(book.ID);
            if (existing != null)
            {
                existing.BookName = book.BookName;
                existing.Genre = book.Genre;
                existing.AvailabilityStatus = book.AvailabilityStatus;

                _context.SaveChanges();
            }
        }
    }
}
