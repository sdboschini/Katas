namespace KataNumberToLCD
{
    public class SingleNumberRowsFactory : ISingleNumberRowsFactory
    {
        public LcdNumberRows Create(string topRow, string centralRow, string bottomRow)
        {
            LcdNumberRows lcdNumberRows = new LcdNumberRows();
            lcdNumberRows.TopRow = topRow;
            lcdNumberRows.CentralRow = centralRow;
            lcdNumberRows.BottomRow = bottomRow;
            return lcdNumberRows;
        }
    }
}