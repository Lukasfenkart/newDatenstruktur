using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStack
{
    public class Palindrom
    {
        public static void Main()
        {
            Console.Write("Geben Sie ein Wort ein: ");
            string input = Console.ReadLine();

            if (IsPalindrome(input))
            {
                Console.WriteLine($"{input} ist ein Palindrom.");
            }
            else
            {
                Console.WriteLine($"{input} ist kein Palindrom.");
            }
        }

        static bool IsPalindrome(string eingabe)
        {
            eingabe = eingabe.ToLower(); 

            Stack<char> stack = new Stack<char>();

            int laenge = eingabe.Length;
            int halbelaenge = laenge / 2;

            for (int i = 0; i < halbelaenge; i++)
            {
                stack.Push(eingabe[i]);
            }

            int startIndex = (laenge % 2 == 0) ? halbelaenge : halbelaenge + 1;

            for (int i = startIndex; i < laenge; i++)
            {
                if (eingabe[i] != stack.Pop())
                {
                    return false;
                }
            }

            return true;
        }
    }

}
