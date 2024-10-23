using MyHomeWork5;

static void main()
{
    Library library = new Library();
    Book book1 = new Book("To Kill a Mockingbird", "Harper Lee", "0000000001", 1);
    Book book2 = new Book("The Book Thief", " Markus Zusak", "0000000002", 2);
    Book book3 = new Book("The Hunger Games", " Suzanne Collins", "0000000003", 3);
    Book book4 = new Book("Harry Potter and the Sorcerer’s Stone(#1)", "J.K. Rowling", "123456789", 4);

    book1.DisplayInfo();
    book2.DisplayInfo();
    book3.DisplayInfo();
    book4.DisplayInfo();
    
    //book1.BorrowBook();
    //book1.ReturnBook();
    
    //library.AddBook(book1);
    //library.AddBook(book2);
    //library.AddBook(book3);
    //library.RemoveBook("To Kill a Mockingbird");
    //library.DisplayAllBooks();
}

main();
