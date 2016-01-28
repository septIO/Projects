using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lars
{
    using static Console;
    class Program
    {
        
        static void Main(string[] args)
        {
            Title = "Username and password";//angiver en titel til vinduet
            string username, password;

            username = "Lars";
            password = "lol";

            while (true)//Kører kode som står indenfor {} indtil et break
            {

                Write("Enter username: ");
                username = ReadLine().ToLower();
                Write("Enter password: ");
                password = ReadLine().ToLower();//to.lower laver input til lowercase, uanset om store bogstaver bruges

                if (username != "" && password != "")//!= betyder ikke ligmed, og == betyder ligmed.
                {
                    WriteLine("The username or password you entered is incorrect");
                    continue;//Fortsætter igangværende loop
                }
                else
                {
                    Clear();

                    // Top border
                    SetCursorPosition((WindowWidth - 30) / 2, (WindowHeight - 8) / 2);
                    for (int i = 1; i <= 15; i++) Write("↓↑");

                    // Bottom border
                    SetCursorPosition((WindowWidth - 30) / 2, (WindowHeight + 8) / 2);
                    for (int i = 1; i <= 15; i++) Write("↓↑");

                    // Side borders
                    for (int i = (WindowHeight - 7) / 2; i <= (WindowHeight - 7) / 2 + 6; i++)
                    {
                        SetCursorPosition((WindowWidth + 27) / 2, i);
                        Write("↓↑");
                        SetCursorPosition((WindowWidth - 30) / 2, i);
                        Write("↓↑");
                    }


                    ForegroundColor = ConsoleColor.Yellow;
                    SetCursorPosition((WindowWidth - 8) / 2, WindowHeight / 2);
                    Write("Welcome!");

                }
                ReadKey();
                break;//Stopper loop

            }
        }
    }
}
