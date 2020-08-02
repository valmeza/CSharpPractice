using System;

namespace CSharpPractice
{
    class Program
    {

        static void Main(string[] args)
        {
            // data types
            //string phrase = "This is a phrase";
            //char grade = 'a';
            //short num = 1;
            //byte num2 = 10;
            //int num3 = 10;
            //float num4 = 1.2f;
            //double num5 = 3.14159;
            //long num6 = 1L;
            //bool conditional = true;
            //bool coditional2 = false;

            //int min = int.MinValue;
            //int max = int.MaxValue;

            //Console.WriteLine($"The range of the integers are {min} to {max}");

            //double min = double.MinValue;
            //double max = double.MaxValue;

            //Console.WriteLine($"The range of the doubles are {min} to {max}");

            //double third = 1.0 / 3.0;
            //Console.WriteLine(third);

            //decimal min = decimal.MinValue;
            //decimal max = decimal.MaxValue;

            //Console.WriteLine($"The range of the decimals are {min} to {max}");

            //double a = 1.0;
            //double b = 3.0;
            //Console.WriteLine(a / b);

            //decimal c = 1.0M;
            //decimal d = 3.0M;
            //Console.WriteLine(c / d);

            //double radius = 2.50;
            //double area = Math.PI * radius * radius;
            //Console.WriteLine(area);

            //Console.Write("Enter your name: ");
            //string userResponse = Console.ReadLine();

            //Console.WriteLine($"Hello {userResponse}");


            //Console.WriteLine("Enter a number: ");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter another number: ");
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(num1 + num2);

            string color, pluralNoun, celebrity;

            Console.Write("Enter a color: ");
            color = Console.ReadLine();

            Console.Write("Enter a plural noun: ");
            pluralNoun = Console.ReadLine();

            Console.Write("Enter a celebrity name: ");
            celebrity = Console.ReadLine();

            Console.WriteLine($"Roses are {color}");
            Console.WriteLine($"{pluralNoun} are blue");
            Console.WriteLine($"I love {celebrity}");

            Console.ReadLine();
        }
    }
}
