using NUnit.Framework;

namespace KataNumberToLCD.Tests
{
    [TestFixture]
    public class LcdNumberTest
    {
        private LcdNumber _sut;

        [SetUp]
        public void Init()
        {
            _sut = new LcdNumber(new LcdSingleNumber(new SingleNumberRowsFactory()));
        }
        
        [Test]
        public void GetLcdNumber_HappyPath()
        {
            string number = "1234567890";
            var lcdNumber = _sut.GetLcdNumber(number);
            Assert.AreEqual(lcdNumber.TopRow,     "    _  _     _  _  _  _  _  _ ");
            Assert.AreEqual(lcdNumber.CentralRow, "  | _| _||_||_ |_   ||_||_|| |");
            Assert.AreEqual(lcdNumber.BottomRow,  "  ||_  _|  | _||_|  ||_| _||_|");
        }
       
        [TestCase(" ", "   ")]
        [TestCase(".", "   ")]
        [TestCase(",", "   ")]
        public void GetLcdNumber_InputIsNotANumber_ReturnDefaultEmptyValue(string character, string expected)
        {
            var lcdSingleNumber = _sut.GetLcdNumber(character);
            Assert.AreEqual(lcdSingleNumber.TopRow, expected);
            Assert.AreEqual(lcdSingleNumber.CentralRow, expected);
            Assert.AreEqual(lcdSingleNumber.BottomRow, expected);
        }
    }
}