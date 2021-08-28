using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _01_Simple_Calculator.Test.Unit
{
    [TestClass]
    public class InputConverterTest
    {
        private readonly InputConverter _inputConverter = new InputConverter();

        [TestMethod]
        public void ConvertsValidStringInputIntoDouble()
        {
            string inputText = "2";
            double result = _inputConverter.ConvertInputToNumeric(inputText);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FailsToConvertInvalidStringInputIntoDouble()
        {
            string inputText = "asdf";
            double result = _inputConverter.ConvertInputToNumeric(inputText);
        }
    }
}
