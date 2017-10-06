using NUnit.Framework;

namespace KataNumberToLCD.Tests
{
    [TestFixture]
    public class LcdSingleNumberTest
    {
        private LcdDigit _sut;

        [SetUp]
        public void Init()
        {
            _sut = new LcdDigit(new DigitRowsFactory());
        }

        [TestCase("0", " _ ", "| |", "|_|")]
        [TestCase("1", "   ", "  |", "  |")]
        [TestCase("2", " _ ", " _|", "|_ ")]
        [TestCase("3", " _ ", " _|", " _|")]
        [TestCase("4", "   ", "|_|", "  |")]
        [TestCase("5", " _ ", "|_ ", " _|")]
        [TestCase("6", " _ ", "|_ ", "|_|")]
        [TestCase("7", " _ ", "  |", "  |")]
        [TestCase("8", " _ ", "|_|", "|_|")]
        [TestCase("9", " _ ", "|_|", " _|")]
        public void GetLcdSingleNumber_HappyPath(string number, string topRow, string centerRow, string bottomRow)
        {
            var lcdSingleNumber = _sut.GetLcdDigit(number);
            Assert.AreEqual(lcdSingleNumber.TopRow, topRow);
            Assert.AreEqual(lcdSingleNumber.CentralRow,  centerRow);
            Assert.AreEqual(lcdSingleNumber.BottomRow, bottomRow);
        }

        [TestCase(" ")]
        [TestCase(".")]
        [TestCase(",")]
        public void GetSingleNumber_InputIsNotANumber_ReturnDefaultEmptyValue(string character)
        {
            var lcdSingleNumber = _sut.GetLcdDigit(character);
            Assert.AreEqual(lcdSingleNumber.TopRow, "   ");
            Assert.AreEqual(lcdSingleNumber.CentralRow, "   ");
            Assert.AreEqual(lcdSingleNumber.BottomRow, "   ");
        }
    }
}