using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataNumberToLCD
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = "";
            var validator = new NumberValidator();
            var lcdNumber = new LcdNumber(new LcdDigit(new DigitRowsFactory()), new LcdNumberRows()); // dependence injection - utilizzare le interfacce (contengono solo i metodi pubblici)
            while (number != null && number.ToString().ToUpper() != "E")
            { 
                Console.Write("Scrivi un numero [E=Exit]: ");
                number = Console.ReadLine();
                if (validator.IsValid(number))
                {
                    var lcdNumberRows = lcdNumber.GetLcdNumber(number);
                    Console.WriteLine(lcdNumberRows.TopRow);
                    Console.WriteLine(lcdNumberRows.CentralRow);
                    Console.WriteLine(lcdNumberRows.BottomRow);
                }
                else
                {
                    Console.WriteLine("Il numero inserito non è valido.");
                }
            }
        }
    }
}
