using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WordGameLibrary
{
    public static class Alphabet
    {
       public static char[] constanants = new char[]
            {
                'b','c','d','f','g','h','j','k','l','m','n','p','q','r','s','t','v','w','x','y','z'
            };
       public static char[] vowels = new char[]
        {
                'a','e','i','o','u'
        };

       public static char[] EntrireAlphabet_VowelsFirst()
       {
           List<char> ret = new List<char>();
           foreach (char i in vowels) { ret.Add(i); }
           foreach (char i in constanants) { ret.Add(i); }
           return ret.ToArray();
            
       }
    }
}
