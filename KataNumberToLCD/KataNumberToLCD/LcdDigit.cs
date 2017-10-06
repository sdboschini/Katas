using System.Collections;
using System.Runtime.InteropServices;

namespace KataNumberToLCD
{
    public class LcdDigit
    {
        private readonly ISingleNumberRowsFactory _singleNumberRowsFactory;
        private const string _NNN = "   ";
        private const string _NUN = " _ ";
        private const string _PNP = "| |";
        private const string _PUP = "|_|";
        private const string _NNP = "  |";
        private const string _NUP = " _|";
        private const string _PUN = "|_ ";

        public LcdDigit(ISingleNumberRowsFactory singleNumberRowsFactory)
        {
            _singleNumberRowsFactory = singleNumberRowsFactory;
        }

        public LcdNumberRows GetLcdSingleNumber(string number)
        {
            return GetLcdSingleNumberRows(number);
        }

        private LcdNumberRows GetLcdSingleNumberRows(string number)
        {
            switch (number)
            {
                case "0":
                    return _singleNumberRowsFactory.Create(_NUN, _PNP, _PUP);
                case "1":
                    return _singleNumberRowsFactory.Create(_NNN, _NNP, _NNP);
                case "2":
                    return _singleNumberRowsFactory.Create(_NUN, _NUP, _PUN);
                case "3":
                    return _singleNumberRowsFactory.Create(_NUN, _NUP, _NUP);
                case "4":
                    return _singleNumberRowsFactory.Create(_NNN, _PUP, _NNP);
                case "5":
                    return _singleNumberRowsFactory.Create(_NUN, _PUN, _NUP);
                case "6":
                    return _singleNumberRowsFactory.Create(_NUN, _PUN, _PUP);
                case "7":
                    return _singleNumberRowsFactory.Create(_NUN, _NNP, _NNP);
                case "8":
                    return _singleNumberRowsFactory.Create(_NUN, _PUP, _PUP);
                case "9":
                    return _singleNumberRowsFactory.Create(_NUN, _PUP, _NUP);
                default:
                    return _singleNumberRowsFactory.Create(_NNN, _NNN, _NNN);
            }
        }
    }
}