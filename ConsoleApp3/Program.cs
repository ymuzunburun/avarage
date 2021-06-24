using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merhaba, Hoşgeldiniz. Girdiğiniz iki sayıyının ortalamasını gösteren program.");
            Console.WriteLine("1.sayıyı giriniz.");
            double number1, number2, average;
            number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2.sayıyı giriniz.");
            number2 = Convert.ToDouble(Console.ReadLine());
            
            average = (number1 + number2) / 2;
            Console.WriteLine("İki Sayının Ortalaması " + average);
            
        }
    }
}
