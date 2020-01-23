using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace DataStructures.Stack
{
    public class StringBalancer
    {
        private static readonly char[] OPEN_CHARACTERS = {'<', '{', '[', '('};
        private static readonly char[] CLOSE_CHARACTERS = {'>', '}', ']', ')'};

        public bool IsStringBalanced(string input)
        {
            var clearString = ClearStringFromRegularSings(input);
            var charactersStack = new Stack<char>();

            foreach (var character in clearString)
            {
                if (OPEN_CHARACTERS.Contains(character))
                {
                    charactersStack.Push(character);
                }
                if (CLOSE_CHARACTERS.Contains(character))
                {
                    if (!charactersStack.Any())
                    {
                        return false;
                    }

                    var top = charactersStack.Pop();
                    if (!IsBracketsMatch(character, top))
                    {
                        return false;
                    }
                }

            }

            return !charactersStack.Any();
        }

        private bool IsBracketsMatch(char right, char left)
        {
            return Array.IndexOf(OPEN_CHARACTERS, left) == Array.IndexOf(CLOSE_CHARACTERS, right);
        }

        private string ClearStringFromRegularSings(string input)
        {
            var regTemplate = @"\d|\n|\s|[a-zA-Z]|\+|\-|";

            var clearString = Regex.Replace(input, regTemplate, "");

            return clearString;
        }
    }
}