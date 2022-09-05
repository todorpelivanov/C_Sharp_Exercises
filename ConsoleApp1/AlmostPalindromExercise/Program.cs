using System;
using System.Linq;

namespace AlmostPalindromExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result = MainLogic("htyyrghhuryyth"); //true
            var result2 = MainLogic("kayak"); //false
            var result3 = MainLogic("todor"); //true
            var result4 = MainLogic("exercise"); //fasle
            Console.WriteLine(result);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
            Console.WriteLine(result4);
        }

        private static bool MainLogic(string input) 
        {
            if (IsPalindrome(input)) 
            {
                return false;
            }
            
            var inputSplited = input.ToCharArray();

            return LetterChanger(inputSplited);

        }

        private static bool LetterChanger(char[] input)
        {
            char[] az = Enumerable.Range('a', 'z' - 'a' + 1).Select(i => (Char)i).ToArray();

            for (int i = 0; i < input.Length; i++)
            {
                var tempstring = new String(input).Remove(i, 1);

                for (int x = 0; x < az.Length; x++)
                {             
                    var insertTemp = tempstring.Insert(i, az[x].ToString());

                    if (IsPalindrome(insertTemp)) 
                    {
                        return true;
                    }
                }

            }

            return false;
        }

        private static bool IsPalindrome(string input) 
        {
            if (input == new string(input.Reverse().ToArray())) 
            {
                return true;
            }

            return false;
        }
    }
}
