
using DigitalBooks.Enum;
using DigitalBooks.Flyweight;

namespace DigitalBooks
{
    public interface IBook
    {
        DateTime BorrowingDate { get; set; }
        int Id { get; set; }
        bool IsItBorrowed { get; set; }
        BookFlyweight Flyweight { get; set; }



    }
}