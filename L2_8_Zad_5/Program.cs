using System;

namespace L2_8_Zad_5
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program dla liczb od 1 do 20 wyświetli na ekranie ich trzecią potęgę.");

            int counter = 1;

            while (counter <= 20)
            {
                double numberAfterPow = Math.Pow(counter, 3);
                Console.WriteLine($"Trzeca potęga liczby {counter} to: {numberAfterPow}");
                counter++;
            }
        }
    }
}
