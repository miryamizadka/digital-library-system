using DigitalBooks.Adapter;
using DigitalBooks.Bridge;
using DigitalBooks.Composite;
using DigitalBooks.Decorator;
using System;

namespace DigitalBooks.Proxy
{
    internal class BookProxy
    {
        public bool Borrow(IBook book, UserRole userRole)
        {
            if (book.IsItBorrowed)
            {
                Console.WriteLine("The book is already borrowed.");
                return false; 
            }

            if (userRole == UserRole.premium || !(book is RareBook))
            {
                book.IsItBorrowed = true;
                Console.WriteLine($"Book '{book.Flyweight.Name}' borrowed successfully.");
                return true;
            }

            Console.WriteLine("Access Denied: Only premium users can borrow rare books.");
            return false;
        }
        public void Information(IBook book, UserRole userRole, IColor color)
        {
            if (userRole == UserRole.premium || !(book is RareBook))
            {
                ColorBookAdapter bookProvider = new ColorBookAdapter(book);
                Display display = new BookDisplay(color, bookProvider);
                display.Render();
                Console.WriteLine($"Information about the book '{book.Flyweight.Name}' displayed successfully.");
            }
            else
            {
                Console.WriteLine("Access Denied: Only premium users can view rare books.");
            }
        }
    }
}