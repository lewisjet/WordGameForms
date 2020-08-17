using System;
using System.Collections.Generic;
using System.Text;

namespace WordGameLibrary
{
   public class RandomChars
    {
        public RandomChars(out List<char> @return, int vowelCount, int constanantCount)
        {
            @return = new List<char>();
            for (int i = 0; i < vowelCount; i++)
            {
                @return.Add
                    (
                        Alphabet.vowels[new Random().Next(0, Alphabet.vowels.Length)]
                    );
            }
            for (int i = 0; i < constanantCount; i++)
            {
                @return.Add
                    (
                        Alphabet.constanants[new Random().Next(0, Alphabet.constanants.Length)]
                    );
            }
        }
    }
}
