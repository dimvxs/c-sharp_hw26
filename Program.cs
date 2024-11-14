using System;

namespace hw
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            Money money1 = new Money(10, 50);  
            Money money2 = new Money(5, 75);   

            // Показать начальные значения
            Console.WriteLine($"money1: {money1}");
            Console.WriteLine($"money2: {money2}");

            // Операция сложения
            Money sum = money1 + money2;
            Console.WriteLine($"money1 + money2 = {sum}");

            // Операция вычитания
            Money difference = money1 - money2;
            Console.WriteLine($"money1 - money2 = {difference}");

            // Операция инкремента
            money1++;
            Console.WriteLine($"money1 after increment: {money1}");

            // Операция декремента
            money2--;
            Console.WriteLine($"money2 after decrement: {money2}");

            // Операция умножения
            Money multiplied = money1 * 2;  
            Console.WriteLine($"money1 * 2 = {multiplied}");

            // Операция деления
            Money divided = money2 / 2; 
            Console.WriteLine($"money2 / 2 = {divided}");

            // Сравнение
            bool isGreater = money1 > money2;
            bool isLess = money1 < money2;
            bool isEqual = money1 == money2;

            Console.WriteLine($"money1 > money2: {isGreater}");
            Console.WriteLine($"money1 < money2: {isLess}");
            Console.WriteLine($"money1 == money2: {isEqual}");
        }
    }
}
