using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookKeepingSystem
{
    public class Business
    {
        private readonly DataHandler _dataHandler;
        public List<Book> Books { get; private set; }

        public Business()
        {
            _dataHandler = new DataHandler();
            Books = _dataHandler.LoadBooks();
        }

        public void AddBook(Book book)
        {
            Books.Add(book);
            _dataHandler.SaveBooks(Books);
        }

        public void DeleteBook(string title)
        {
            Books.RemoveAll(b => b.Title.Equals(title, System.StringComparison.OrdinalIgnoreCase));
            _dataHandler.SaveBooks(Books);
        }

        public List<Book> GetAllBooks()
        {
            return Books;
        }
    }
}

