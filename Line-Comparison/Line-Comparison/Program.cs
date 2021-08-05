using System;

namespace Line_Comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, y1, y2,length;
            Console.WriteLine("Enter the values of x1,x2,y1,y2");
            x1 = double.Parse(Console.ReadLine());
            x2 = double.Parse(Console.ReadLine());
            y1 = double.Parse(Console.ReadLine());
            y2 = double.Parse(Console.ReadLine());
            length = Math.Sqrt(Math.Pow(x2 - x1 , 2) + Math.Pow(y2- y1 , 2));
            Console.WriteLine("The length of co-ordinates :" + length);
        }

    }
}
