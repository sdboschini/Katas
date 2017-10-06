using System;

namespace KataNumberToLCD
{
    public class LcdNumber
    {
        private readonly LcdDigit _lcdDigit;
        private readonly LcdNumberRows _lcdNumberRows;

        public LcdNumber(LcdDigit lcdDigit, LcdNumberRows lcdNumberRows) // ctor + tab crea in automatico il costruttore
        {
            _lcdDigit = lcdDigit; // se non voglio passare LcdDigit devo usare il new... questo però non permette di effettuare i test
            _lcdNumberRows = lcdNumberRows;
        }

        public LcdNumberRows GetLcdNumber(string number)
        {
            LcdNumberRows lcdNumberRows = new LcdNumberRows();
            foreach (char digit in number)
            {
                var lcdDigit = _lcdDigit.GetLcdDigit(digit.ToString());
                _lcdNumberRows.ConcatDigit(lcdNumberRows, lcdDigit);
            }
            return lcdNumberRows;
        }
    }
}