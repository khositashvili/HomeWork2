using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MyHomeWork5
{
    public class Book
    {
        //Fileds
        private string _title;
        private string _author;
        private string _isbn;
        private int _totalCopies;
        private int _copiesAvailable;
        
        //Propertes
        public string Title {
            get { return _title; }
            set { _title = value; }
        }
        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }
        public string ISBN 
        {
            set 
            {
                if (_isbn.Length == 10)
                {
                    //_isbn = value;
                }
                else
                {
                    //Console.WriteLine("ISBN must be exactly 10 digits.");
                }
            }
        }
        public int TotalCopies
        {
            get { return _totalCopies; }
            set { _totalCopies = value; }
        }
        public int CopiesAvailable
        {
            get { return _copiesAvailable; }
            set { _copiesAvailable = value; }
        }

        //Constructor
        public Book (string title, string author, string isbn, int totalCopies)
        {
            Title = title;
            Author = author;
            _isbn = isbn;
            TotalCopies = totalCopies;
            CopiesAvailable = totalCopies;
        }

        //Methods
        public void DisplayInfo()
        {
            Console.WriteLine($"\"{Title}\" by {Author} (ISBN:{_isbn}). Copies available: {CopiesAvailable}");
        }

        public void BorrowBook()
        {
            if (CopiesAvailable > 0)
            {
                CopiesAvailable--; // Reduce the number of available copies.
                Console.WriteLine($"You have successfully borrowed \"{Title}\" by {Author}. Copies left: {CopiesAvailable}");
            }
            else
            {
                Console.WriteLine($"Sorry, no copies of \"{Title}\" are available.");
            }
        }

        public void ReturnBook()
        {
            if (CopiesAvailable < TotalCopies)
            {
                CopiesAvailable++; // Increase the number of available copies.
                Console.WriteLine($"You have successfully returned \"{Title}\" by {Author}. Available copies: {CopiesAvailable}");
            }
            else
            {
                Console.WriteLine($"All copies of \"{Title}\" are already in the library.");
            }
        }

    }

    public class Library
    {
        //Field
        private List<Book> books;

        // Constructor
        public Library()
        {
            books = new List<Book>();
        }
        //Methods
        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine($"Book \"{book.Title}\" by {book.Author} added to the library.");
        }
        public void RemoveBook(string title)
        {
            Book bookToRemove = books.Find(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));

            if (bookToRemove != null)
            {
                books.Remove(bookToRemove);
                Console.WriteLine($"Book \"{title}\" has been removed from the library.");
            }
            else
            {
                Console.WriteLine($"Book \"{title}\" not found in the library.");
            }
        }

        public void DisplayAllBooks()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("No books available in the library.");
            }
            else
            {
                Console.WriteLine("Books in the library:");
                foreach (var book in books)
                {
                    book.DisplayInfo();
                    Console.WriteLine(); //Blank line between books
                }
            }
        }

        public void Search(string query)
        {
            List<Book> searchResults = books.FindAll(b =>
                b.Title.IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0 ||
                b.Author.IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0);

            if (searchResults.Count > 0)
            {
                Console.WriteLine($"Search results for \"{query}\":");
                foreach (var book in searchResults)
                {
                    book.DisplayInfo();
                    Console.WriteLine(); // Blank line between results
                }
            }
            else
            {
                Console.WriteLine($"Book \"{query}\" is not  in library.");
            }
        }
    }

}