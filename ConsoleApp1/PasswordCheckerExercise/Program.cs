using System;
using System.Collections.Generic;
using System.Linq;

namespace PasswordCheckerExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> rawInput = new List<string>()
            {
                "a 1-3: abcde",
                "b 1-3: cdefg",
                "c 2-9: ccccccccc"
            };

            var invalidPasswords = 0;

            foreach (var item in rawInput)
            {
                if (!CheckPassword(item))
                {
                    invalidPasswords++;
                }
            }

            Console.WriteLine(invalidPasswords);
        }


        public static bool CheckPassword(string input)
        {
            var inputSplited = input.Split(null);
            var letter = inputSplited[0].ToCharArray().First();
            var criteria = inputSplited[1];
            var password = inputSplited[2];

            if (password.Contains(letter))
            {
                var numberOfLetters = password.Count(x => x == letter);
                var splitedCriteria = criteria.Split(":").First().Split("-");

                if (numberOfLetters >= int.Parse(splitedCriteria.First()) || numberOfLetters <= int.Parse(splitedCriteria.Last()))
                {
                    return true;
                }

                return false;
            }
            else
            {
                return false;
            }
        }
    }
}
