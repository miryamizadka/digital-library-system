using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalBooks.Decorator
{
    internal class LibraryUseOnly : BookDecorator
    {
        
        public LibraryUseOnly(IBook book):base(book)
        {
        }
        public override string ToString()
        {
            return $"Library use only - {base.ToString()}"; 
        }
    }
}
