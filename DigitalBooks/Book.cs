using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigitalBooks.Adapter;
using DigitalBooks.Enum;
using DigitalBooks.Flyweight;

namespace DigitalBooks
{

    public class Book : IBookProvider, IBook
    {

        public static int IdCode = 0;
        public int Id { get; set; }
        public BookFlyweight Flyweight { get; set; }
        public bool IsItBorrowed { get; set; }=false;

        public DateTime BorrowingDate { get; set; }
        public Book(string name, string Auther,BookCategory bookCategory)
        {
            Id = ++IdCode;
            BorrowingDate = DateTime.Now;
            Flyweight = new BookFlyweight(name, Auther, bookCategory);
        }
        public Book()
        {
            Id = ++IdCode;
        }
        public override string ToString()
        {
            return $"Name is:{Flyweight.Name}\nAuthor is:{Flyweight.Author}\nId is:{Id}\nIsItBorrowed is:{IsItBorrowed}\nBorrowingDate is:{BorrowingDate}\n";
        }


    }
}



