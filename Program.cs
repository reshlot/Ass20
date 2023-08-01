using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAss20
{
    public class Program
    {
       public  static void Main(string[] args)
        {
            Library library = new Library();

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("------------------------");
                Console.WriteLine("Library Management System");
                Console.WriteLine("------------------------");
                Console.WriteLine("1. Add a book");
                Console.WriteLine("2. View all books");
                Console.WriteLine("3. Search book by ID");
                Console.WriteLine("4. Search book by title");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: \n ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter book details:\n");
                        Book newBook = new Book();
                        Console.Write("Book ID: ");
                        newBook.BookId = int.Parse(Console.ReadLine());
                        Console.Write("Title: ");
                        newBook.Title = Console.ReadLine();
                        Console.Write("Author: ");
                        newBook.Author = Console.ReadLine();
                        Console.Write("Genre: ");
                        newBook.Genre = Console.ReadLine();
                        Console.Write("Is Available (true/false): ");
                        newBook.IsAvailable = bool.Parse(Console.ReadLine());
                        library.AddBook(newBook);
                        Console.WriteLine("***Book added successfully.***");
                        break;

                    case 2:
                        library.ViewAllBooks();
                        break;

                    case 3:
                        Console.Write("Enter book ID to search: \n");
                        int bookId = int.Parse(Console.ReadLine());
                        library.SearchBookById(bookId);
                        break;

                    case 4:
                        Console.Write("Enter book title to search:\n ");
                        string title = Console.ReadLine();
                        library.SearchBookByTitle(title);
                        break;

                    case 5:
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("-> Invalid choice. Please try again.");
                        break;
                }
                Console.WriteLine("Thank you for using the Library Management System.");

            }
          
        }
        
    }
}
    

