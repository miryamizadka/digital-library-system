using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigitalBooks.Adapter;

namespace DigitalBooks.Bridge
{
    public class BookDisplay : Display
    {
        public BookDisplay(IColor color, ColorBookAdapter bookProvider) : base(color, bookProvider)
        {
        }

        public override void Render()
        {
            ConsoleColor bookColor = bookProvider.GetColor();
            color.ApplyColor(bookColor);
            Console.WriteLine(bookProvider.ToString());
            color.ResetColor();
        }
    }
}
