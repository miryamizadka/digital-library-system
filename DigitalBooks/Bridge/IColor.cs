using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalBooks.Bridge
{
    public interface IColor
    {
        void ApplyColor(ConsoleColor color);
        void ResetColor();
    }
}
