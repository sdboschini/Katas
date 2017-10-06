using NUnit.Framework;

namespace KataNumberToLCD.Tests
{
    [TestFixture]
    public class LcdSingleNumberTest
    {
        private LcdSingleNumber _sut;

        [SetUp]
        public void Init()
        {
            _sut = new LcdSingleNumber(new SingleNumberRowsFactory());
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
            var lcdSingleNumber = _sut.GetLcdSingleNumber(number);
            Assert.AreEqual(lcdSingleNumber.TopRow, topRow);
            Assert.AreEqual(lcdSingleNumber.CentralRow,  centerRow);
            Assert.AreEqual(lcdSingleNumber.BottomRow, bottomRow);
        }

        [TestCase(" ")]
        [TestCase(".")]
        [TestCase(",")]
        public void GetSingleNumber_InputIsNotANumber_ReturnDefaultEmptyValue(string character)
        {
            var lcdSingleNumber = _sut.GetLcdSingleNumber(character);
            Assert.AreEqual(lcdSingleNumber.TopRow, "   ");
            Assert.AreEqual(lcdSingleNumber.CentralRow, "   ");
            Assert.AreEqual(lcdSingleNumber.BottomRow, "   ");
        }
    }
}