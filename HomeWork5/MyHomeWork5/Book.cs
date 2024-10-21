using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHomeWork5
{
    public class Book
    {
        //Fileds
        private string _title;
        private string _author;
        private int _isbn;
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
        public int ISBN
        {
            set { _isbn = value; }
        }
        public int CopiesAvailable
        {
            get { return _copiesAvailable; }
            set { _copiesAvailable = value; }
        }

        //Methods
        public void DissplayInfo()
        {

        }
        public void BorrowBook()
        {

        }
        public void ReturnBook()
        {
            _isbn ++;
        }

    }

    public class Library
    {
        private string books {  get; set; }
    
        public void AddBook ()
        {

        }
        public void RemoveBook()
        {

        }
        public void DisplayAllBooks()
        {

        }



    }
    

}