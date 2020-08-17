using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WordGameLibrary
{
  public static class DictionaryGrabber
    {
       public static List<string> ConsoleBeg()
        {
            while (true)
            {
                Console.WriteLine("Dictionary Please!");
                string input = Console.ReadLine();
                Console.Clear();
                try { return File.ReadAllLines(@input).ToList(); }
                catch { Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Invalid Path"); Console.ForegroundColor = ConsoleColor.White; }
            }
        }
       
        public static List<string> GetFromPath(string path)
        {
            try { return File.ReadAllLines(@path).ToList(); }
            catch { return null; }
        }

    }
}
