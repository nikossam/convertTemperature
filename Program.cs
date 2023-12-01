using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertTemperature
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool option = true;
            int choice;

            while(option)
            {
                Console.WriteLine("Enter 1 if you want to convert Fahrenheit in Celsius: ");
                Console.WriteLine("Enter 2 if you want to convert Celsius in Fahrenheit: ");
                Console.WriteLine("Enter 3 if you want to exit program: ");
                choice = Convert.ToInt32(Console.ReadLine());

                if(choice == 1)
                {
                    Console.Write("Enter temperature in Fahrenheit: ");
                    double fahrenheit = Convert.ToDouble(Console.ReadLine());

                    double celsius = (fahrenheit - 32) * 5 / 9;

                    Console.WriteLine($"Temperature in Celsius: {celsius:F2}°C");
                    Console.WriteLine("\n");
                }
                else if(choice == 2)
                {
                    Console.Write("Enter temperature in Celsius: ");
                    double celsius = Convert.ToDouble(Console.ReadLine());

                    double fahrenheit = (celsius * 9 / 5) + 32;

                    Console.WriteLine($"Temperature in Fahrenheit: {fahrenheit:F2}°F");
                    Console.WriteLine("\n");
                }
                else if( choice == 3) 
                {
                    Console.WriteLine("Exiting program.");
                    option = false;
                }
                Console.ReadKey();

            }
            
        }
    }
}
