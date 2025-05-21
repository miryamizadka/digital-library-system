using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigitalBooks.Enum;

namespace DigitalBooks.Adapter



{
    public class ColorBookAdapter : IBookProvider
    {
        private readonly IBook _book;
        private readonly Dictionary<BookCategory, ConsoleColor> _categoryColorDic;

        public ColorBookAdapter(IBook book)
        {
            _book = book;
            _categoryColorDic = new Dictionary<BookCategory, ConsoleColor>
            {
                {BookCategory.Adult, ConsoleColor.Cyan },
                {BookCategory.Biography, ConsoleColor.Red },
                {BookCategory.Holocaust, ConsoleColor.Yellow },
                {BookCategory.YoungAdult, ConsoleColor.Blue },
                {BookCategory.SelfHelp, ConsoleColor.DarkGreen },
                {BookCategory.ChildrensBooks, ConsoleColor.Magenta },
                {BookCategory.Thriller, ConsoleColor.DarkGray },
                {BookCategory.History, ConsoleColor.Blue},
                {BookCategory.NA, ConsoleColor.Black },
            };
        }

        public ConsoleColor GetColor()
        {
            return _categoryColorDic.GetValueOrDefault(_book.Flyweight.Category, ConsoleColor.White);
        }

        public override string ToString()
        {
            return _book.ToString();
        }



    }
}
