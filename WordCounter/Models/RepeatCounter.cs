using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace WordCounter.Models
{
    public class RepeatCounter
    {
        public bool checkSpecialCharacters(string input)
        {
            bool validInput = input.All(Char.IsLetter);

            return validInput;
        }

        public string removeSpecialCharacters(string input)
        {
            char[] letterArray = input.ToCharArray();

            letterArray = Array.FindAll<char>(letterArray, (c => (char.IsLetterOrDigit(c) || c == '-')));

            input = new string(letterArray);

            return input;
        }
    }
}
