using System;

namespace Lesson9Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of first side:");
            double size1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter size of second side:");
            double size2 = double.Parse(Console.ReadLine());
            
            Rectangle rectangle1 = new Rectangle(size1, size2);
            
            Console.WriteLine($"Area:{ rectangle1.Area}");
            Console.WriteLine($"Perimetr:{rectangle1.Perimetr}");
        }
    }
}
