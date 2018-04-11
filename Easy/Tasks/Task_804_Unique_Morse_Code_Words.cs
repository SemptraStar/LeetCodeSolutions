using System.Collections.Generic;
using System.Linq;

namespace LeetCodeProjects.Easy.Tasks
{
    public class Task_804_Unique_Morse_Code_Words
    {
        public int UniqueMorseRepresentations(string[] words)
        {
            Dictionary<char, string> charsToMorse = BuildCharToMorseDictionary();

            var uniqueMorseStrings = new HashSet<string>();

            foreach(var word in words)
            {
                uniqueMorseStrings.Add(GetMorseString(word, charsToMorse));
            }

            return uniqueMorseStrings.Count;
        }

        private Dictionary<char, string> BuildCharToMorseDictionary()
        {
            var morseChars = new string[] { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };

            var charsToMorse = new Dictionary<char, string>();

            int i = 0;

            for (char c = 'a'; c <= 'z'; c++, i++)
            {
                charsToMorse.Add(c, morseChars[i]);
            }

            return charsToMorse;
        }

        private string GetMorseString(string str, Dictionary<char, string> charsToMorse)
        {
            return string.Join("", str.Select(c => charsToMorse[c]).ToArray());
        }
    }
}
