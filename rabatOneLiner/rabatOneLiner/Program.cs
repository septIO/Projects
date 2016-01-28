using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rabatOneLiner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Indtast beløb: ");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Rabat: {0}% ({1})\nTotal: {2}", 
            i<1000?0:i<5000?10:15,i*(i<1000?0:i<5000?10:15)/100,i-(i*(i<1000?0:i<5000?10:15)/100));
            Console.ReadKey();
        }
    }
}
