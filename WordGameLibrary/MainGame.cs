using System;
using System.Collections.Generic;
using System.Text;

namespace WordGameLibrary
{
   public class MainGame
    {
        private int score;

        public int Score
        {
            get { return score; }
            set { score = value; }
        }

        private List<char> currentChars;

        public List<char> CurrentChars
        {
            get { return currentChars; }
            set { currentChars = value; }
        }

        private List<string> wordsEntered;

        public List<string> WordsEntered
        {
            get { return wordsEntered; }
            set { wordsEntered = value; }
        }


        public MainGame(List<char> currentChars)
        {
            CurrentChars = currentChars;
            wordsEntered = new List<string>();
        }
        
        

        

        public void CalculationsOnly(string inputch, List<string> dictionary)
        {
            inputch = inputch.ToLower();
            bool isValidWord = false;
            char[] charsinInputch = inputch.ToCharArray();
            int accuratechars = 0;
            foreach (char character in charsinInputch)
            {
                if (currentChars.Contains(character))
                { accuratechars++; }
            }

            if (accuratechars == charsinInputch.Length)
            {
                foreach (string word in dictionary)
                {
                    if (word == inputch && !wordsEntered.Contains(inputch)) { isValidWord = true; }
                }
            }

            if (isValidWord) { score++; wordsEntered.Add(inputch); }
        }

        public void ConsoleApp(List<string> dictionary)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            foreach (char @char in currentChars) { Console.Write(@char); }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(score.ToString());
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            string inputch = Console.ReadLine();
            inputch = inputch.ToLower();
            bool isValidWord = false;
            char[] charsinInputch = inputch.ToCharArray();
            int accuratechars = 0;
            foreach (char character in charsinInputch)
            {
                if (currentChars.Contains(character))
                { accuratechars++; }
            }

            if (accuratechars == charsinInputch.Length)
            {
                foreach (string word in dictionary)
                {
                    if (word == inputch && !wordsEntered.Contains(inputch)) { isValidWord = true; }
                }
            }

            if (isValidWord) { score++; wordsEntered.Add(inputch); }
            Console.Clear();
        }
    }
}
