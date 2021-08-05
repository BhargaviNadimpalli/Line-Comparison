using System;

namespace Line_Comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, x2,x3,x4,y1, y2,y3,y4,length1,length2;
            Console.WriteLine("Enter the values of x1,x2,y1,y2");
            x1 = double.Parse(Console.ReadLine());
            x2 = double.Parse(Console.ReadLine());
            y1 = double.Parse(Console.ReadLine());
            y2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the values of x3,x3,y3,y4");
            x3 = double.Parse(Console.ReadLine());
            x4 = double.Parse(Console.ReadLine());
            y3 = double.Parse(Console.ReadLine());
            y4 = double.Parse(Console.ReadLine());
            length1 = Math.Sqrt(Math.Pow(x2 - x1 , 2) + Math.Pow(y2- y1 , 2));
            length2 = Math.Sqrt(Math.Pow(x4 - x3, 2) + Math.Pow(y4 - y3, 2));
            Console.WriteLine("The length of first co-ordinates :" + length1);
            Console.WriteLine("The length of second co-ordinates :" + length2);
            if (length1 == length2)
            {
                Console.WriteLine("The length1 and length2 are equal");
            }
            else if (length1 > length2)
            {
                Console.WriteLine("The length1 is greater than length2");
                
            }
            else
            {
                Console.WriteLine("The length1 is less than length2");
            }
        }

    }
}
