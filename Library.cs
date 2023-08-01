using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAss20
{
    public  class Library
    {

        private List<Book> books;

        public Library()
        {
            books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void ViewAllBooks()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("!!!1No books available in the library.");
            }
            else
            {
                Console.WriteLine("List of all books:");
                foreach (var book in books)
                {
                    Console.WriteLine($"Book ID: {book.BookId}");
                    Console.WriteLine($"Title: {book.Title}");
                    Console.WriteLine($"Author: {book.Author}");
                    Console.WriteLine($"Genre: {book.Genre}");
                    Console.WriteLine($"Is Available: {(book.IsAvailable ? "Yes" : "No")}");
                    Console.WriteLine("------------------------");
                }
            }
        }

        public void SearchBookById(int bookId)
        {
            var book = books.Find(b => b.BookId == bookId);
            if (book != null)
            {
                Console.WriteLine($"Book ID: {book.BookId}");
                Console.WriteLine($"Title: {book.Title}");
                Console.WriteLine($"Author: {book.Author}");
                Console.WriteLine($"Genre: {book.Genre}");
                Console.WriteLine($"Is Available: {(book.IsAvailable ? "Yes" : "No")}");
            }
            else
            {
                Console.WriteLine("!!!1Book not found.");
            }
        }

        public void SearchBookByTitle(string title)
        {
            var book = books.Find(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
            if (book != null)
            {
                Console.WriteLine($"Book ID: {book.BookId}");
                Console.WriteLine($"Title: {book.Title}");
                Console.WriteLine($"Author: {book.Author}");
                Console.WriteLine($"Genre: {book.Genre}");
                Console.WriteLine($"Is Available: {(book.IsAvailable ? "Yes" : "No")}");
            }
            else
            {
                Console.WriteLine("!!!Book not found.");
            }
        }
    }
}

