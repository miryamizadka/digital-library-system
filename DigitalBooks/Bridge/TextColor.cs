using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalBooks.Bridge
{
    public class TextColor : IColor
    {

        public void ApplyColor(ConsoleColor color)
        {
            Console.ForegroundColor = color;
        }

        public void ResetColor()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
