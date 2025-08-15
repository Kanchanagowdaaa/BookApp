using DAL_Book.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Book.Repo
{
    public interface IRepository
    {

        void AddBook(BookDetail book);
        void DeleteBook(int bookId);
        BookDetail GetBookById(int bookId);
        IEnumerable<BookDetail> GetAllBooks();
        void UpdateBook(BookDetail book);

    }
}
