using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApplication3
{
    using static Console;
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("t");
            WriteLine("t");
            WriteLine("t");
            WriteLine("t");

            int i = 1;
            for (i = 1; i <= 100; i++)
            {
                string t = new string('■', i % 50);
                
                SetCursorPosition(0,4);
                Write(i);
                SetCursorPosition(0, 5);
                Write(t);
                if (i % 50 == 0)
                {
                    Write(new string(' ', 50));
                }
                Thread.Sleep(30);
            }

            ReadKey();

        }
    }
}
