using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            ConsoleKeyInfo Key = Console.ReadKey();
            char ch = Key.KeyChar;

            if (ch == '/')
                Console.WriteLine("{0}", a / b);

            Console.ReadKey();
            Console.ReadKey();
        }
    }
}
