using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    using static Console;
    class Program
    {
        static char snake = '■';
        static char food = '#';

        static ConsoleColor foodColor = ConsoleColor.Yellow;
        static int gridSize = 20;
        static ConsoleKey direction;

        static Random randomGenerator = new Random();

        static void Main(string[] args)
        {
            int curX, curY;
            //CursorVisible = false;
            curX = 10; //Starting positions
            curY = 10; //Starting positions

            spawnFood(curX, curY);
            SetCursorPosition(0, 0);
            Write(new string(snake, 4));

            ConsoleKey up = ConsoleKey.UpArrow;
            ConsoleKey down = ConsoleKey.DownArrow;
            ConsoleKey left = ConsoleKey.LeftArrow;
            ConsoleKey right = ConsoleKey.RightArrow;

            ConsoleKeyInfo cki;
            while (true)
            {
                cki = Console.ReadKey();
                if (cki.Key == up ||
                    cki.Key == right ||
                    cki.Key == down ||
                    cki.Key == left) direction = cki.Key;
                    
            }

            ReadKey();

        }

        static void spawnFood(int x, int y)
        {
            int fX = randomGenerator.Next(gridSize + 1);
            int fY = randomGenerator.Next(gridSize + 1);
            SetCursorPosition(fX, fY);

            ForegroundColor = foodColor;
            Write(food);
            
            ForegroundColor = ConsoleColor.White;
        }

        static void move()
        {

        }
    }
}
