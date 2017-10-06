namespace KataNumberToLCD
{
    public interface ISingleNumberRowsFactory
    {
        LcdNumberRows Create(string topRow, string centralRow, string bottomRow);
    }
}