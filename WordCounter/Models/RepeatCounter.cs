using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace WordCounter.Models
{
    public class RepeatCounter
    {
        public bool CheckSpecialCharacters(string input)
        {
            bool validInput = input.All(Char.IsLetter);

            return validInput;
        }

        public string RemoveSpecialCharacters(string input)
        {
            char[] letterArray = input.ToCharArray();

            letterArray = Array.FindAll<char>(letterArray, (c => (char.IsLetterOrDigit(c) || char.IsWhiteSpace(c) || c == '-')));

            input = new string(letterArray);

            return input;
        }

        public string RemoveWhiteSpace(string input)
        {
            char[] letterArray = input.ToCharArray();

            letterArray = Array.FindAll<char>(letterArray, (c => !char.IsWhiteSpace(c)));

            input = new string(letterArray);

            return input;
        }
    }
}
