using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigitalBooks.Adapter;
using DigitalBooks.Enum;
using DigitalBooks.Flyweight;

namespace DigitalBooks.Decorator
{
    public class BookDecorator : IBook, IBookProvider
    {
        public IBook Book { get; set; }
        public BookFlyweight Flyweight { get {return Book.Flyweight; } set { Book.Flyweight = value; } }
        public DateTime BorrowingDate { get { return Book.BorrowingDate; } set { Book.BorrowingDate = value; } }
        public int Id { get { return Book.Id; } set { Book.Id = value; } }
        public bool IsItBorrowed { get { return Book.IsItBorrowed; } set { Book.IsItBorrowed = value; } }

        public BookDecorator(IBook book)
        {
            Book = book;
        }

        public override string ToString()
        {
            return Book.ToString();
        }
    }
}
