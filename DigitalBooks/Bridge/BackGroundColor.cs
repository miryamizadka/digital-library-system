using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalBooks.Bridge
{
    public class BackGroundColor : IColor
    {

        public void ApplyColor(ConsoleColor color)
        {
            Console.BackgroundColor = color;
        }

        public void ResetColor()
        {
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
