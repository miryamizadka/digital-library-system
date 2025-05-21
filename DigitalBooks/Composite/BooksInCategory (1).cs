using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigitalBooks.Enum;

namespace DigitalBooks.Composite
{
    public class BooksInCategory
    {
        BookCategory Category { get; set; }
        List<BooksInCategory> subCategories = new List<BooksInCategory>();
        List<IBook> books = new List<IBook>();

        public BooksInCategory(BookCategory _category, List<BooksInCategory> _subCategories)
        {
            Category = _category;
            subCategories = _subCategories;
        }


        public bool AddBook(IBook book)
        {
            if (Category == book.Flyweight.Category)
            {
                books.Add(book);
                return true;
            }
            if (subCategories == null)
            {
                return false;
            }
            foreach (var cat in subCategories)
            {
                if (book.Flyweight.Category.HasFlag(cat.Category))
                {
                    return cat.AddBook(book);
                }
            }
            return false;
        }

        public bool Borrow(IBook book)
        {
            if (Category == book.Flyweight.Category)
            {
                var bookInCategory = books.Find(b => b.Id == book.Id);
                if (bookInCategory != null && !bookInCategory.IsItBorrowed)
                {
                    bookInCategory.IsItBorrowed = true;
                    bookInCategory.BorrowingDate = DateTime.Now;
                    return true;
                }
            }
            if (subCategories == null)
            {
                return false;
            }
            foreach (var cat in subCategories)
            {
                if (book.Flyweight.Category.HasFlag(cat.Category))
                {
                    return cat.Borrow(book);
                }
            }
            return false;
        }

        public List<IBook> GetBooksByCategory(BookCategory category)
        {
            List<IBook> result = new List<IBook>();

            if (this.Category == category)
            {
                result.AddRange(books);
            }

            if (subCategories != null && subCategories.Any())
            {
                foreach (var subCategory in subCategories)
                {
                    result.AddRange(subCategory.GetBooksByCategory(category));
                }
            }

            return result;
        }

        public void PrintBooks()
        {
            foreach (var book in books)
            {
                Console.WriteLine($"Book: {book.Flyweight.Name}, Author: {book.Flyweight.Name}");
            }

            if (subCategories != null && subCategories.Any())
            {
                foreach (var subCategory in subCategories)
                {
                    subCategory.PrintBooks();
                }
            }

        }
    }
}
