using NUnit.Framework;

namespace KataNumberToLCD.Tests
{
    [TestFixture]
    public class NumberValidatorTest
    {
        private NumberValidator _sut;

        [SetUp]
        public void Init()
        {
            _sut = new NumberValidator();
        }

        [TestCase("1234567890")]
        [TestCase(" 1234567890 ")]
        public void IsValid_HappyPath_ReturnTrue(string number)
        {
            var isAValidNumber = _sut.IsValid(number);
            Assert.IsTrue(isAValidNumber);
        }

        [TestCase("123.")]
        [TestCase("1 23")]
        public void IsValid_NumberIsNotAnInt_ReturnFalse(string number)
        {
            var isAValidNumber = _sut.IsValid(number);
            Assert.IsFalse(isAValidNumber);
        }
    }
}