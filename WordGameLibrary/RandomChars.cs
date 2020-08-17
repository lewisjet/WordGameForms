using System;
using System.Collections.Generic;
using System.Text;

namespace WordGameLibrary
{
   public class RandomChars
    {
        public RandomChars(out List<char> returntype, int vowelCount, int constanantCount)
        {
            returntype = new List<char>();
            for (int i = 0; i < vowelCount; i++)
            {
                returntype.Add
                    (
                        Alphabet.vowels[new Random().Next(0, Alphabet.vowels.Length)]
                    );
            }
            for (int i = 0; i < constanantCount; i++)
            {
                returntype.Add
                    (
                        Alphabet.constanants[new Random().Next(0, Alphabet.constanants.Length)]
                    );
            }

        }

        public RandomChars(out List<char> returntype, int vowelCount, int constanantCount, Random random)
        {
            returntype = new List<char>();
            for (int i = 0; i < vowelCount; i++)
            {
                returntype.Add
                    (
                        Alphabet.vowels[random.Next(0, Alphabet.vowels.Length)]
                    );
            }
            for (int i = 0; i < constanantCount; i++)
            {
                returntype.Add
                    (
                        Alphabet.constanants[random.Next(0, Alphabet.constanants.Length)]
                    );
            }
        }

    }
}
