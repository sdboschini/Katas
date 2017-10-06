namespace KataNumberToLCD
{
    public class SingleNumberRowsFactory : ISingleNumberRowsFactory
    {
        public LcdNumberRows Create(string topRow, string centralRow, string bottomRow)
        {
            LcdNumberRows lcdNumberRows = new LcdNumberRows
            {
                TopRow = topRow,
                CentralRow = centralRow,
                BottomRow = bottomRow
            };
            return lcdNumberRows;
        }
    }
}