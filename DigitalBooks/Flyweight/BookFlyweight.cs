using DigitalBooks.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalBooks.Flyweight
{
    public class BookFlyweight 
    {
        public string Name { get; private set; }
        public string Author { get; private set; }
        public BookCategory Category { get; private set; }

        public BookFlyweight(string name, string author, BookCategory category)
        {
            Name = name;
            Author = author;
            Category = category;
        }

    }
}
