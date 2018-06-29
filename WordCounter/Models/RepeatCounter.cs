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
    }
}
