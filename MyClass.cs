using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAppClassTest1
{
    internal class MyClass
    {
        private int x=0, y=0;

        public MyClass(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void display()
        {
            Console.WriteLine($"({x},{y})");
        }
    }
}
