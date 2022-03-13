using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAppClassTest1
{
    internal class MyStack
    {
        const int MAX_BUF = 256;
        private string[] buf = new string[MAX_BUF];
        private int top = 0;

        public MyStack()
        {
            this.top = 0;
        }

        public void Show()
        {
            for (int i=0; i<top; i++)
            {
                Console.Write(buf[i]+",");
            }
            Console.WriteLine();   
        }
                
        public string Pop()
        {
            if (top > 0)
                return this.buf[--this.top];
            else
                return "";
        }

        public void Push(string val)
        {
            if(top < MAX_BUF)
                this.buf[this.top++] = val;
        }
    }
}
