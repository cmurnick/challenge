using System;
using System.Collections.Generic;
using System.Linq;

namespace CodingChallenge.PirateSpeak
{
    public class Solution
    {

        public string[] GetPossibleWords(string jumble, string[] dictionary)
        {
            //I think that I need to break out the string jumble and parse it to single letters
            // then loop through the single letters and send to a list
            // then make a dictionary

            //string str = jumble;
            //char[] charArray = str.ToCharArray();
            //string[] strArray = str.Select(x => x.ToString()).ToArray();

            string message = jumble;
            string[] result = new string[message.Length];
            char[] letters = new char[message.Length];

            letters = message.ToCharArray();

            List<string> listLetters = new List<string>();
            var please = "";
            for (int i = 0; i < message.Length - 1; i++)
            {
                result[i] = Convert.ToString(letters[i]);

                if (dictionary.Contains(result[i]))
                {
                    result[i] = Convert.ToString(letters[i]);
                    listLetters.Add(result[i]);
                    please = result[i];
                }
            }
            return dictionary;
        }
    }
}
            
        
