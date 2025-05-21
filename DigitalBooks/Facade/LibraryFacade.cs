using DigitalBooks.Adapter;
using DigitalBooks.Bridge;
using DigitalBooks.Composite;
using DigitalBooks.Enum;
using DigitalBooks.Flyweight;
using DigitalBooks.Proxy;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DigitalBooks.Facade
{
    public class LibraryFacade
    {
        private readonly BooksInCategory _allCategories;
        private readonly BookProxy _bookProxy;

        public LibraryFacade()
        {
            Book book1 = new Book("The Great Gatsby", "F. Scott Fitzgerald", BookCategory.YoungAdult)
            {
                BorrowingDate = DateTime.Now
            };

            Book book2 = new Book("1984", "George Orwell", BookCategory.Thriller)
            {
                BorrowingDate = DateTime.Now
            };

            ColorBookAdapter bookProvider1 = new ColorBookAdapter(book1);
            ColorBookAdapter bookProvider2 = new ColorBookAdapter(book2);
            IColor textColor = new TextColor();
            IColor backgroundColor = new BackGroundColor();

            BooksInCategory youngadulCategory = new BooksInCategory(BookCategory.YoungAdult, null);
            BooksInCategory thrillerCategory = new BooksInCategory(BookCategory.Thriller, null);

            _allCategories = new BooksInCategory(BookCategory.NA, new List<BooksInCategory> { youngadulCategory, thrillerCategory });

            youngadulCategory.AddBook(book1);
            thrillerCategory.AddBook(book2);

            _bookProxy = new BookProxy();
        }

        public bool BorrowBook(IBook book, UserRole userRole)
        {
            return _bookProxy.Borrow(book, userRole);
        }

        public bool ReturnBook(IBook book)
        {
            if (!book.IsItBorrowed)
            {
                Console.WriteLine($"Book '{book.Flyweight.Name}' has not borrowed yet.");
                return false;
            }
            book.IsItBorrowed = false;
            Console.WriteLine($"Book '{book.Flyweight.Name}' returned successfully.");
            return true;
        }

        public bool GetBookAvailability(IBook book)
        {
            return !book.IsItBorrowed;
        }

        public void PrintBook(IBook book, IColor color, UserRole userRole)
        {
            _bookProxy.Information(book, userRole, color);
        }

        public void PrintBooksInCategory(BookCategory category, IColor color, UserRole userRole)
        {
            var booksInCategory = _allCategories.GetBooksByCategory(category);

            foreach (var book in booksInCategory)
            {
                PrintBook(book, color, userRole);
            }
        }
    }
}
