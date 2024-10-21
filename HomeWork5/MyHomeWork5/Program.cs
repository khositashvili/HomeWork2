using MyHomeWork5;

static void main()
{
    Library library = new Library();
    Book book1 = new Book("To Kill a Mockingbird", "Harper Lee", "00001", 2);
    Book book2 = new Book("The Book Thief", " Markus Zusak", "00002", 3);
    Book book3 = new Book("The Hunger Games", " Suzanne Collins", "00003", 4);
    Book book4 = new Book("Harry Potter and the Sorcerer’s Stone(#1)", "J.K. Rowling", "00004", 5);

    //book1.DisplayInfo();
    //book2.DisplayInfo();
    //book3.DisplayInfo();
    //book4.DisplayInfo();
    //book1.BorrowBook();
    //book1.BorrowBook();
    //book1.BorrowBook();
    //book1.BorrowBook(); //Sorry, no copies of "To Kill a Mockingbird" are currently available.
    //book1.ReturnBook(); //You have successfully returned "To Kill a Mockingbird" by Harper Lee. Available copies: 1

    //library.AddBook(book1);
    //library.AddBook(book2);
    library.AddBook(book3);
    library.AddBook(book4);
    library.RemoveBook("Harry Potter and the Sorcerer’s Stone(#1)");
    library.DisplayAllBooks();
    library.Search("Suzanne Collins");
}

main();
