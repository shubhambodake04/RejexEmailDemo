using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RejexEmailDemo

{
    class Pattern
    {
        string regex = "^[a-z0-9A-Z]+([.#@_][a-zA-Z0-9]+)?[@][a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,2})?$";

        public bool Check(string input)
        {
            return Regex.IsMatch(input, regex);
        }
    }
}