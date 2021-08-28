using System;

namespace NestedConditionsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 20;
            if (a > b)
            {
                if (a >= 15)
                {
                    Console.WriteLine(a + " is greater than or equal to 15");
                }
                else
                {
                    Console.WriteLine(a + " is less than");
                }
            }
            else
            {
                if (b <= 20)
                {
                    Console.WriteLine(b + " is less than or equal to 20");
                }
                else
                {
                    Console.WriteLine(b + " is less than 20");
                }
            }
            Console.ReadKey();
        }
    }
}
