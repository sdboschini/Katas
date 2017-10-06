namespace KataNumberToLCD
{
    public interface IDigitRowsFactory
    {
        LcdNumberRows Create(string topRow, string centralRow, string bottomRow);
    }
}