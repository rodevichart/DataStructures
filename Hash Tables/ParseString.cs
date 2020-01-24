using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructures.Hash_Tables
{
    public static class ParseString
    {
        public static char GetFirstNonRepeatableCharacter(string input)
        {
            var characters = input.ToLower();

            var dictionary = new Dictionary<char, int>();
            foreach (var character in characters)
            {
                if (dictionary.ContainsKey(character))
                { 
                    dictionary.TryGetValue(character, out var index);
                    dictionary.Remove(character);
                    dictionary.Add(character, ++index);
                }
                else
                {
                    dictionary.Add(character, 1);
                }
            }

            var returnCharacter = '\0';

            foreach (var character in characters)
            {
                dictionary.TryGetValue(character, out var value);

                if (value == 1)
                {
                    returnCharacter = character;
                    break;
                }
            }

            return returnCharacter;
        }

    }
}