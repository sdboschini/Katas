namespace KataNumberToLCD
{
    public class DigitRowsFactory : IDigitRowsFactory
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