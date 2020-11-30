using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionMenuExample
{
    class EmptyItem : IMenuItem
    {
        public string Description => throw new NotImplementedException();

        public char Code => throw new NotImplementedException();

        public void Display(int width)
        {
            throw new NotImplementedException();
        }
    }
}
