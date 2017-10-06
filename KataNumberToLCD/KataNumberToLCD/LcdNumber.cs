using System;

namespace KataNumberToLCD
{
    public class LcdNumber
    {
        private readonly LcdSingleNumber _lcdSingleNumber;

        public LcdNumber(LcdSingleNumber lcdSingleNumber) // ctor + tab
        {
            _lcdSingleNumber = lcdSingleNumber; // se non voglio passare LcdSingleNumber devo usare il new... questo però non permette di effettuare i test
        }

        public LcdNumberRows GetLcdNumber(string number)
        {
            LcdNumberRows lcdNumberRows = new LcdNumberRows();
            foreach (char digit in number)
            {
                var lcdSingleNumber = _lcdSingleNumber.GetLcdSingleNumber(digit.ToString()); // SingleNumber... meglio usare digit
                lcdNumberRows.TopRow = string.Concat(lcdNumberRows.TopRow, lcdSingleNumber.TopRow); // la concatenazione meglio farla con un metodo all'interno della classe LcdNumberRows
                lcdNumberRows.CentralRow = string.Concat(lcdNumberRows.CentralRow, lcdSingleNumber.CentralRow);
                lcdNumberRows.BottomRow = string.Concat(lcdNumberRows.BottomRow, lcdSingleNumber.BottomRow);
            }
            return lcdNumberRows;
        }
    }
}