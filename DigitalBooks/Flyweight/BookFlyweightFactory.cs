using DigitalBooks.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalBooks.Flyweight
{
    public class BookFlyweightFactory
    {
        private readonly Dictionary<string, BookFlyweight> _flyweights = new Dictionary<string, BookFlyweight>();

        public BookFlyweight GetFlyweight(string name, string author, BookCategory category)
        {
            string key = $"{name}-{author}-{category}";

            if (!_flyweights.ContainsKey(key))
            {
                _flyweights[key] = new BookFlyweight(name, author, category);
            }

            return _flyweights[key];

        }
    }
}
