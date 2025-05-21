using System;
using DigitalBooks;
using DigitalBooks.Adapter;
using DigitalBooks.Bridge;
using DigitalBooks.Composite;
using DigitalBooks.Decorator;
using DigitalBooks.Facade;
using DigitalBooks.Flyweight;
using DigitalBooks.Proxy;
using DigitalBooks.Enum;

namespace DigitalBooksApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Demonstrate Adapter Pattern
            Console.WriteLine("Testing Adapter Pattern");
            Book book1 = new Book("The Great Gatsby", "F. Scott Fitzgerald", BookCategory.Biography);
            ColorBookAdapter bookProvider = new ColorBookAdapter(book1);
            Console.WriteLine(bookProvider.ToString());

            // Demonstrate Bridge Pattern
            Console.WriteLine("\nTesting Bridge Pattern");
            IColor textColor = new TextColor();
            IColor backgroundColor = new BackGroundColor();
            Display bookDisplayWithTextColor = new BookDisplay(textColor, bookProvider);
            bookDisplayWithTextColor.Render();
            Display bookDisplayWithBackgroundColor = new BookDisplay(backgroundColor, bookProvider);
            bookDisplayWithBackgroundColor.Render();

            // Demonstrate Composite Pattern
            Console.WriteLine("\nTesting Composite Pattern");
            BooksInCategory youngadulCat = new BooksInCategory(BookCategory.YoungAdult, null);
            BooksInCategory youngadulSelfHelpCat = new BooksInCategory(BookCategory.YoungAdult | BookCategory.SelfHelp, null);
            youngadulCat.AddBook(book1);
            youngadulSelfHelpCat.AddBook(book1);
            Console.WriteLine("Books in Young adul category:");
            youngadulCat.PrintBooks();

            // Demonstrate Decorator Pattern
            Console.WriteLine("\nTesting Decorator Pattern");
            IBook rareBook = new Book("Rare Book", "Author", BookCategory.Holocaust);
            rareBook = new RareBook(rareBook);
            Console.WriteLine(rareBook.ToString());
            rareBook = new LibraryUseOnly(rareBook);
            Console.WriteLine(rareBook.ToString());

            // Demonstrate Flyweight Pattern
            Console.WriteLine("\nTesting Flyweight Pattern");
            BookFlyweightFactory flyweightFactory = new BookFlyweightFactory();
            BookFlyweight flyWeight1 = flyweightFactory.GetFlyweight("Moby Dick", "Herman Melville", BookCategory.History);
            BookFlyweight flyWeight2 = flyweightFactory.GetFlyweight("The Great Gatsby", "F. Scott Fitzgerald", BookCategory.YoungAdult);
            Console.WriteLine($"Flyweight 1: {flyWeight1.Name}, {flyWeight1.Author}, {flyWeight1.Category}");
            Console.WriteLine($"Flyweight 2: {flyWeight2.Name}, {flyWeight2.Author}, {flyWeight2.Category}");

            // Demonstrate Facade Pattern
            Console.WriteLine("\nTesting Facade Pattern");
            LibraryFacade facade = new LibraryFacade();  

            // Demonstrate Proxy Pattern
            Console.WriteLine("\nTesting Proxy Pattern");
            BookProxy proxy = new BookProxy();
            UserRole userRole = UserRole.standard;
            bool isBorrowed = proxy.Borrow(book1, userRole); 
            Console.WriteLine($"Borrow status: {isBorrowed}");

            // Additional checks for Proxy
            proxy.Information(rareBook, userRole, textColor);
            userRole = UserRole.premium;
            isBorrowed = proxy.Borrow(book1, userRole); 
            Console.WriteLine($"Borrow status for premium user: {isBorrowed}");
            proxy.Information(book1, userRole, textColor);


        }
    }
}
