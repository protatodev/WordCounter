using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace WordCounter.Models
{
    public class RepeatCounter
    {
        public string GetInputtedWord()
        {
            return "word";
        }

        public string[] GetInputtedPhrase()
        {
            return SplitPhrase("this is a phrase");
        }

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

        public string[] SplitPhrase(string input)
        {
            string[] wordArray = input.Split(" ");

            return wordArray;
        }

        public int CountOccurences(string word, string[] words)
        {
            int occurences = 0;

            for(int i = 0; i < words.Length; i++)
            {
                if(words[i] == word)
                {
                    occurences++;
                }
            }

            return occurences;
        }

        public Dictionary<string, int> GetUniquePhraseWordCount(string[] words)
        {
            Dictionary<string, int> wordCount = new Dictionary<string, int>() { };

            foreach(string word in words)
            {
                if(wordCount.ContainsKey(word))
                {
                    wordCount[word] += 1;
                } 
                else
                {
                    wordCount.Add(word, 1);
                }
            }

            return wordCount;
        }
    }
}
