using System;
using System.Text.RegularExpressions;

namespace KataNumberToLCD
{
    public class NumberValidator // IntegerNumberValidator
    {
        public bool IsValid(string number) // Validate
        {
            return int.TryParse(number, out _) ? true : false;
        }
    }
}