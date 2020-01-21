using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace DataStructures
{
    public class StringBalancer
    {
        public bool IsStringBalanced(string input)
        {
            var clearString = ClearStringFromRegularSings(input);
            var inputStack = new Stack<char>();

            foreach (var character in clearString)
            {
                inputStack.Push(character);
            }

            var reverseString = new StringReverser();

            var reverseStack = reverseString.ReverseStackFromString(clearString);

            return true;
        }

        private string ClearStringFromRegularSings(string input)
        {
            var regTemplate = @"\d|\n|\s|[a-zA-Z]|\+|\-|";

            var clearString = Regex.Replace(input, regTemplate, "");

            return clearString;
        }
    }
}