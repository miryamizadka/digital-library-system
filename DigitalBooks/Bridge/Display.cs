using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigitalBooks.Adapter;

namespace DigitalBooks.Bridge
{
    public abstract class Display
    {
        protected IColor color;
        protected ColorBookAdapter bookProvider;

        protected Display(IColor color, ColorBookAdapter bookProvider)
        {
            this.color = color;
            this.bookProvider = bookProvider;
        }

        public abstract void Render();
    }
}
