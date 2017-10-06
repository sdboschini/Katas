namespace KataNumberToLCD
{
    public class LcdNumberRows
    {
        public string TopRow { get; set; }
        public string CentralRow { get; set; }
        public string BottomRow { get; set; }

        public LcdNumberRows ConcatDigit(LcdNumberRows lcdNumberRows, LcdNumberRows lcdDigit)
        {
            lcdNumberRows.TopRow = string.Concat(lcdNumberRows.TopRow, lcdDigit.TopRow);
            lcdNumberRows.CentralRow = string.Concat(lcdNumberRows.CentralRow, lcdDigit.CentralRow);
            lcdNumberRows.BottomRow = string.Concat(lcdNumberRows.BottomRow, lcdDigit.BottomRow);
            return lcdNumberRows;
        }
    }
}