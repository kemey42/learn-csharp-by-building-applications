using System;
using System.Collections.Generic;
using System.Text;

namespace _01_Simple_Calculator
{
    public class InputConverter
    {
        public double ConvertInputToNumeric(string argTextInput) 
        {
            double convertedNumber;
            if (!double.TryParse(argTextInput, out convertedNumber)) throw new ArgumentException("Expected a numeric value");
            return convertedNumber;
        }
    }
}
