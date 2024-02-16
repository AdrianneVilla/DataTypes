using System;

namespace DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter the piece/s of Apple: ");
            int apple = Convert.ToInt32(Console.ReadLine());   

            Console.Write($"Enter the total price of {apple} apple(s):  ");
            double totalPrice = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"The total price of {apple} apple(s) is {totalPrice} ");
            Console.WriteLine($"The value of original price is {totalPrice}");

            int convertedPrice = (int)totalPrice;
            Console.WriteLine($"The value of converted price is {convertedPrice}");
            
        }
    }
}