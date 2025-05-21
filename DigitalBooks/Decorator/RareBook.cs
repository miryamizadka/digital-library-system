using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalBooks.Decorator
{
    internal class RareBook : BookDecorator
    {
        public RareBook(IBook book) : base(book)
        {
        }
        public override string ToString()
        {
            return $"Rare book - {base.ToString()}"; 
        }
    }
}
