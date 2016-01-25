using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle_generator
{
    using static Console;
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                SetCursorPosition(0, 0);
                SetWindowSize(50, 50);
                int x, y, radius, circ, area;

                Write("Enter radius: ");
                radius = int.Parse(ReadLine());

                x = radius;
                y = radius;

                ForegroundColor = ConsoleColor.White;
                for (int i = 0; i <= 360; i++)
                {
                    double h, k;

                    h = Math.Ceiling(x + radius * Math.Cos(i));
                    k = Math.Ceiling(y + radius * Math.Sin(i));
                    SetCursorPosition((int)h, (int)k);

                    Write("■");
                }

                ReadKey();
                Clear();
            }
        }
    }
}
