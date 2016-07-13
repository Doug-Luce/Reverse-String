using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            
            while (true)
            {
                String toReverse;
                Console.WriteLine("Input a string to reverse: ");
                toReverse = Console.ReadLine();
                char[] letters = toReverse.ToCharArray();
                Array.Reverse(letters);
                Console.WriteLine(letters);

            }
        }

    }
}
