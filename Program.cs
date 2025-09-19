// See https://aka.ms/new-console-template for more information
using System;

namespace SystemTime
{
    class program
    {
        static void Main(string[] args)
        {
            float width;
            float height;
            /*string value;
            while (false)
            {
                Console.Write("Enter width: ");
                value = Console.ReadLine();
                if (float.TryParse(value, out width))
                {
                   
                    Console.WriteLine("You entered: " + width);
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input! Please enter a numeric value.");
                }
            }
            while (false)
            {
                Console.Write("Enter height: ");
                value = Console.ReadLine();
                if (float.TryParse(value, out height))
                {
                    
                    Console.WriteLine("You entered: " + height);
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input! Please enter a numeric value.");
                }
            }*/
            Console.Write("Enter width: ");
            width = float.Parse(Console.ReadLine());
            Console.Write("Enter height: ");
            height = float.Parse(Console.ReadLine());
            float area = width * height;
            Console.WriteLine("Area is: " + area);
        }
    }

}